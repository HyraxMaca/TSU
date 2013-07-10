

$(document).ready(function()
{
	var thumbnailContainerHeight = $(".news-thumbnails-container").height();
	$(".sidenav-wrapper").height(thumbnailContainerHeight);


	$(".tabbable a:first").tab('show');
});