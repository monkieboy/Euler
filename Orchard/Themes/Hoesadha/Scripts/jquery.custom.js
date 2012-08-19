function boxHeight() {
	var dw = $(document).width();
	var dh = $(document).height();
	var ch = $("#content").height();
	var mt = Math.ceil((dh-ch)/2);
	if ( dw > 720 & mt > 0 ) {
		$("#content").css('paddingTop', mt);
	}
	else if ( dw < 720 ) {
		$("#content").css('paddingTop', 45);
		$("#content").css('marginBottom', 75);
	}
	$('#content').fadeIn('slow');
	$('#socials').fadeIn('slow');
	$('#twitter').fadeIn('slow');
}

// Centering the text content
$(window).resize(function () {
	boxHeight();
}).load(function() {
	boxHeight(); 
	//$("#email").focus();
	$('#content').fadeIn('slow');
}).ready(function(){
	// Email subscripion section
	$('#subscribe-form').submit(function(e){
		e.preventDefault();
		
		email = $('input#email');           
		email_regex = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/;           
		if(!email_regex.test(email.val())) {
			$('#response', form).fadeIn(500, function() {
				$('#response', form).html('<div class="message warning">Invalid email</div>');
			}).fadeOut(4000);
			return;
		} else {
			$('#response', form).html('<div class="message">Please Wait...</div>');
		}
		
		var form = $(this);
		var post_url = form.attr('action');
		var post_data = form.serialize();				
		$.ajax({
			type: 'POST',
			url: post_url,
			data: post_data,
			success: function(msg) {
				$(form).fadeOut(500, function(){
					form.html(msg).fadeIn();
				});
			}
		});
	});
	
	// Tipsy
	$('a.icon').tipsy({ fade: true, gravity: 'n'});
	
	$("a.facebook").hover(function() { $(this).animate({ backgroundColor: "#3B5998" }, 300); },function() {$(this).animate({ backgroundColor: "#000000" }, 600);});	
	$("a.twitter").hover(function() { $(this).animate({ backgroundColor: "#00B7F3" }, 300); },function() {$(this).animate({ backgroundColor: "#000000" }, 600);});	
	$("a.vimeo").hover(function() { $(this).animate({ backgroundColor: "#0DADD6" }, 300); },function() {$(this).animate({ backgroundColor: "#000000" }, 600);});	
	$("a.rss").hover(function() { $(this).animate({ backgroundColor: "#F47D22" }, 300); },function() {$(this).animate({ backgroundColor: "#000000" }, 600);});	
	$("a.google").hover(function() { $(this).animate({ backgroundColor: "#D14629" }, 300); },function() {$(this).animate({ backgroundColor: "#000000" }, 600);});	
	$("a.forrst").hover(function() { $(this).animate({ backgroundColor: "#5B9A68" }, 300); },function() {$(this).animate({ backgroundColor: "#000000" }, 600);});	
	$("a.dribble").hover(function() { $(this).animate({ backgroundColor: "#EF5A92" }, 300); },function() {$(this).animate({ backgroundColor: "#000000" }, 600);});	
	$("a.share").hover(function() { $(this).animate({ backgroundColor: "#359C34" }, 300); },function() {$(this).animate({ backgroundColor: "#000000" }, 600);});	
	$("a.flickr").hover(function() { $(this).animate({ backgroundColor: "#FF0084" }, 300); },function() {$(this).animate({ backgroundColor: "#000000" }, 600);});	
	$("a.digg").hover(function() { $(this).animate({ backgroundColor: "#14589E" }, 300); },function() {$(this).animate({ backgroundColor: "#000000" }, 600);});	
	$("#submit").hover(function() { $(this).animate({ backgroundColor: "red" }, 300); },function() {$(this).animate({ backgroundColor: "orange" }, 600);});	
});