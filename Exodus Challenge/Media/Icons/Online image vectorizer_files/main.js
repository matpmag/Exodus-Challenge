$().ready(function() {
	$("form").validate();

    // please wait box    
    $('#appform').submit(function() {
      if ( $('#appform').valid() ) {
		  $('#uploadMessage').fadeIn('normal');
		  $('#fbut').attr('disabled', 'disabled' );
		  $('#fbut').attr('value', 'processing ...');
		  return true;
		}
    });

    // select textare oncosu
    $("#resultarea").focus(
     function()
     {
      // only select if the text has not changed
      if(this.value == this.defaultValue)
      {
       this.select();
      }
     }
    ) 
});

function CreateBookmarkLink() {
     title = document.title; 
     url = location.href;
	    if (window.sidebar) { // Mozilla Firefox Bookmark
		    window.sidebar.addPanel(title, url,"");
	    } else if( window.external ) { // IE Favorite
		    window.external.AddFavorite( url, title); }
	    else if(window.opera && window.print) { // Opera Hotlist
		    return true; }
     }
