$(document).ready(function () {
    $('#follow-team').click(function () {
        var button = $(this);
        console.log("button clicked!");
        console.log("user " + button.attr("meta-uid"));
        if (button.hasClass("followed")) {
            $.post(
                "http://digitalathleticswebapi.azurewebsites.net/api/follows/unfollow",
                {
                    userId: button.attr("meta-uid"),
                    teamId: button.attr("meta-tid")
                },
                function (data) {
                    button.removeClass("followed");
                    button.html("Follow!");
                    console.log("User " + button.attr("meta-uid") + " has unfollowed team " + button.attr("meta-tid"));
                }
            );
        } else {
            $.post(
                "http://digitalathleticswebapi.azurewebsites.net/api/follows/follow",
                {
                    userId: button.attr("meta-uid"),
                    teamId: button.attr("meta-tid")
                },
                function(data) {
                    button.addClass("followed");
                    button.html("Following!");
                    console.log("User " + button.attr("meta-uid") + " has followed team " + button.attr("meta-tid"));
                }
            );
        }
   });
});