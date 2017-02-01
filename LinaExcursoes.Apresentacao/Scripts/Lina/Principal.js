var Lina = {
    AutoComplete: function (url, id) {
        var cache = {};
        $("#" + id).autocomplete({
            minLength: 2,
            source: function (request, response) {
                var term = request.term;
                if (term in cache) {
                    response(cache[term]);
                    return;
                }

                urlParameter = url + "?termo=" + term;

                $.getJSON(urlParameter, request, function (data, status, xhr) {
                    cache[term] = data;
                   // response(data);
                    response($.map(data, function (item) {
                        return { label: item.link, value: item.descricao };
                    }));
                });
            }
        }).autocomplete("instance")._renderItem = function (ul, item) {
            return $("<li>")
              .append("<div>" + item.link + "<br>" + item.descricao + "</div>")
              .appendTo(ul);
        };
    }
}