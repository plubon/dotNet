$(document).ready(function() {
    $(".place-bet").submit(function (e) {
        e.preventDefault();
        var user_id = 1;
        var match_id = $(this).attr("meta-match");
        var data = $(this).serializeArray();
        $.post("http://digitalathleticswebapi.azurewebsites.net/api/bets",
            {
                userId: user_id,
                matchId: match_id,
                homeScore: data["homeTeamScore"],
                awayScore: data["awayTeamScore"]
            },
            function(data) {
                console.log("DZIALA xD");
            }
        );
    });
});