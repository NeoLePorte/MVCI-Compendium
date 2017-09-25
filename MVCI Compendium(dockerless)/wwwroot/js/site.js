const marvelBtn = $("#marvel-btn");
const marvelChars = $(".marvel-characters");
const capcomChars = $(".capcom-characters");
const capcomBtn = $("#capcom-btn");

$(marvelBtn).click(function () {
    $(capcomChars).hide()
    $(marvelChars).show();
});

$(capcomBtn).click(function () {
    $(marvelChars).hide()
    $(capcomChars).show();
});