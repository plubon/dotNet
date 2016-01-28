$(document).ready(function() {
    $(".place-bet").submit(function (e) {
        e.preventDefault();
        var user_id = $(this).attr("meta-uid");
        var match_id = $(this).attr("meta-match");
        console.log(match_id);
        var data = $(this).serializeArray();
        var homeScore = data[0].value;
        var awayScore = data[1].value;
        $.post("http://digitalathleticswebapi.azurewebsites.net/api/bets",
            {
                userId: user_id,
                matchId: match_id,
                homeScore: homeScore,
                awayScore: awayScore
            },
            function(data) {
                $("#bet-button-" + match_id).remove();
                $("#bet-div-" + match_id).prepend(homeScore + " - " + awayScore);
                $("#BetModal-" + match_id).modal('hide');
            }
        );
    });
}); 