// jQuery.UI.Sample.js
(function($){
Type.registerNamespace('Sample.Accordion');Sample.Accordion._NoAuto=function(){}
Sample.Accordion._Collapse=function(){}
Sample.Accordion._MouseOver=function(){}
Sample.Accordion._HoverIntent=function(){}
Sample.Accordion._Icons=function(){}
Sample.Accordion._Sortable=function(){}
Sample.Accordion._FillSpace=function(){}
Sample.Accordion._Default=function(){}
Type.registerNamespace('Sample.AutoComplete');Sample.AutoComplete.jQueryUISample$5=function(){}
Sample.AutoComplete.jQueryUISample$5.$0=function($p0){$('<div/>').text($p0).prependTo('#log');$('#log').scrollTop(0);}
Sample.AutoComplete._Default=function(){}
Type.registerNamespace('Sample.Position');Sample.Position._Cycling=function(){}
Sample.Position._Default=function(){}
Sample.Position._Default.$0=function($p0){$('.positionable').position({my:$('#my_horizontal').val()+' '+$('#my_vertical').val(),at:$('#at_horizontal').val()+' '+$('#at_vertical').val(),offset:$('#offset').val(),collision:$('#collision_horizontal').val()+' '+$('#collision_vertical').val()});}
Type.registerNamespace('Sample.Sortable');Sample.Sortable._ConnectLists=function(){}
Sample.Sortable.jQueryUISample$6=function(){}
Sample.Sortable._Portlets=function(){}
Sample.Sortable._DispalyAsGrid=function(){}
Sample.Sortable._DelayStart=function(){}
Sample.Sortable._IncludeExclude=function(){}
Sample.Sortable._EmptyLists=function(){}
Sample.Sortable.jQueryUISample$7=function(){}
Sample.Sortable._Default=function(){}
Type.registerNamespace('Sample.Resizable');Sample.Resizable._Animate=function(){}
Sample.Resizable._Textarea=function(){}
Sample.Resizable._ResizeHelper=function(){}
Sample.Resizable.jQueryUISample$8=function(){}
Sample.Resizable._VisualFeedback=function(){}
Sample.Resizable._SnapToGrid=function(){}
Sample.Resizable._DelayStart=function(){}
Sample.Resizable._ResizeArea=function(){}
Sample.Resizable._MaxMinSize=function(){}
Sample.Resizable.jQueryUISample$0=function(){}
Sample.Resizable._Default=function(){}
Type.registerNamespace('Sample.Selectable');Sample.Selectable._DisplayAsGrid=function(){}
Sample.Selectable._Serialize=function(){}
Sample.Selectable._Default=function(){}
Type.registerNamespace('Sample.Draggable');Sample.Draggable.jQueryUISample$1=function(){}
Sample.Draggable._AutoScroll=function(){}
Sample.Draggable.jQueryUISample$2=function(){}
Sample.Draggable._CursorStyle=function(){}
Sample.Draggable._DragHandle=function(){}
Sample.Draggable._VisualFeedback=function(){}
Sample.Draggable._RevertPosition=function(){}
Sample.Draggable._Default=function(){}
Sample.Draggable._DelayStart=function(){}
Sample.Draggable._Events=function(){}
Sample.Draggable._Events.$0=function($p0,$p1){if(!$p0.hasClass('ui-state-hover')){$p0.addClass('ui-state-hover').siblings().removeClass('ui-state-hover');}$('span.count',$p0).text($p1.toString());}
Sample.Draggable._Snap=function(){}
Type.registerNamespace('Sample.Droppable');Sample.Droppable.jQueryUISample$3=function(){}
Sample.Droppable.jQueryUISample$4=function(){}
Sample.Droppable._VisualFeedback=function(){}
Sample.Droppable._Revert=function(){}
Sample.Droppable._ShoppingCart=function(){}
Sample.Droppable._PhotoManager=function(){}
Sample.Droppable._PhotoManager.$0=function($p0){var $0="<a href='link/to/recycle/script/when/we/have/js/off' title='Recycle this image' class='ui-icon ui-icon-refresh'>Recycle image</a>";$p0.fadeOut('slow',function(){
var $1_0=($('ul',$('#trash')).length>0)?$('ul',$('#trash')):$("<ul class='gallery ui-helper-reset'/>").appendTo('#trash');$p0.find('a.ui-icon-trash').remove();$p0.append($0).appendTo($1_0).fadeIn('slow',function(){
$p0.animate({width:'48px'}).find('img').animate({height:'36px'});});});}
Sample.Droppable._PhotoManager.$1=function($p0){var $0="<a href='link/to/trash/script/when/we/have/js/off' title='Delete this image' class='ui-icon ui-icon-trash'>Delete image</a>";$p0.fadeOut('slow',function(){
$p0.find('a.ui-icon-refresh').remove().end().css('width','96px').append($0).find('img').css('height','72px').end().appendTo('#gallery').fadeIn();});}
Sample.Droppable._PhotoManager.$2=function($p0){var $0=$p0.attr('href');var $1=$p0.siblings('img').attr('alt');var $2=$("img[src$='"+$0+"']");if($2.length>0){$2.dialog('open');}else{var $3=$("<img alt='"+$1+"' width='384' height='288' style='display: none; padding: 8px;' />").attr('src',$0).appendTo('body');$3.dialog({title:$1,width:400,modal:true});}}
Sample.Droppable._Default=function(){}
Type.registerNamespace('Sample.ProgressBar');Sample.ProgressBar._ResizableBar=function(){}
Sample.ProgressBar._Animated=function(){}
Sample.ProgressBar._Default=function(){}
Type.registerNamespace('Sample.Widget');Sample.Widget._Default=function(){}
Sample.Accordion._NoAuto.registerClass('Sample.Accordion._NoAuto');Sample.Accordion._Collapse.registerClass('Sample.Accordion._Collapse');Sample.Accordion._MouseOver.registerClass('Sample.Accordion._MouseOver');Sample.Accordion._HoverIntent.registerClass('Sample.Accordion._HoverIntent');Sample.Accordion._Icons.registerClass('Sample.Accordion._Icons');Sample.Accordion._Sortable.registerClass('Sample.Accordion._Sortable');Sample.Accordion._FillSpace.registerClass('Sample.Accordion._FillSpace');Sample.Accordion._Default.registerClass('Sample.Accordion._Default');Sample.AutoComplete.jQueryUISample$5.registerClass('Sample.AutoComplete.jQueryUISample$5');Sample.AutoComplete._Default.registerClass('Sample.AutoComplete._Default');Sample.Position._Cycling.registerClass('Sample.Position._Cycling');Sample.Position._Default.registerClass('Sample.Position._Default');Sample.Sortable._ConnectLists.registerClass('Sample.Sortable._ConnectLists');Sample.Sortable.jQueryUISample$6.registerClass('Sample.Sortable.jQueryUISample$6');Sample.Sortable._Portlets.registerClass('Sample.Sortable._Portlets');Sample.Sortable._DispalyAsGrid.registerClass('Sample.Sortable._DispalyAsGrid');Sample.Sortable._DelayStart.registerClass('Sample.Sortable._DelayStart');Sample.Sortable._IncludeExclude.registerClass('Sample.Sortable._IncludeExclude');Sample.Sortable._EmptyLists.registerClass('Sample.Sortable._EmptyLists');Sample.Sortable.jQueryUISample$7.registerClass('Sample.Sortable.jQueryUISample$7');Sample.Sortable._Default.registerClass('Sample.Sortable._Default');Sample.Resizable._Animate.registerClass('Sample.Resizable._Animate');Sample.Resizable._Textarea.registerClass('Sample.Resizable._Textarea');Sample.Resizable._ResizeHelper.registerClass('Sample.Resizable._ResizeHelper');Sample.Resizable.jQueryUISample$8.registerClass('Sample.Resizable.jQueryUISample$8');Sample.Resizable._VisualFeedback.registerClass('Sample.Resizable._VisualFeedback');Sample.Resizable._SnapToGrid.registerClass('Sample.Resizable._SnapToGrid');Sample.Resizable._DelayStart.registerClass('Sample.Resizable._DelayStart');Sample.Resizable._ResizeArea.registerClass('Sample.Resizable._ResizeArea');Sample.Resizable._MaxMinSize.registerClass('Sample.Resizable._MaxMinSize');Sample.Resizable.jQueryUISample$0.registerClass('Sample.Resizable.jQueryUISample$0');Sample.Resizable._Default.registerClass('Sample.Resizable._Default');Sample.Selectable._DisplayAsGrid.registerClass('Sample.Selectable._DisplayAsGrid');Sample.Selectable._Serialize.registerClass('Sample.Selectable._Serialize');Sample.Selectable._Default.registerClass('Sample.Selectable._Default');Sample.Draggable.jQueryUISample$1.registerClass('Sample.Draggable.jQueryUISample$1');Sample.Draggable._AutoScroll.registerClass('Sample.Draggable._AutoScroll');Sample.Draggable.jQueryUISample$2.registerClass('Sample.Draggable.jQueryUISample$2');Sample.Draggable._CursorStyle.registerClass('Sample.Draggable._CursorStyle');Sample.Draggable._DragHandle.registerClass('Sample.Draggable._DragHandle');Sample.Draggable._VisualFeedback.registerClass('Sample.Draggable._VisualFeedback');Sample.Draggable._RevertPosition.registerClass('Sample.Draggable._RevertPosition');Sample.Draggable._Default.registerClass('Sample.Draggable._Default');Sample.Draggable._DelayStart.registerClass('Sample.Draggable._DelayStart');Sample.Draggable._Events.registerClass('Sample.Draggable._Events');Sample.Draggable._Snap.registerClass('Sample.Draggable._Snap');Sample.Droppable.jQueryUISample$3.registerClass('Sample.Droppable.jQueryUISample$3');Sample.Droppable.jQueryUISample$4.registerClass('Sample.Droppable.jQueryUISample$4');Sample.Droppable._VisualFeedback.registerClass('Sample.Droppable._VisualFeedback');Sample.Droppable._Revert.registerClass('Sample.Droppable._Revert');Sample.Droppable._ShoppingCart.registerClass('Sample.Droppable._ShoppingCart');Sample.Droppable._PhotoManager.registerClass('Sample.Droppable._PhotoManager');Sample.Droppable._Default.registerClass('Sample.Droppable._Default');Sample.ProgressBar._ResizableBar.registerClass('Sample.ProgressBar._ResizableBar');Sample.ProgressBar._Animated.registerClass('Sample.ProgressBar._Animated');Sample.ProgressBar._Default.registerClass('Sample.ProgressBar._Default');Sample.Widget._Default.registerClass('Sample.Widget._Default');(function(){$(function(){
$('#accordion3').accordion({autoHeight:false,navigation:true});});})();
(function(){$(function(){
$('#accordion4').accordion({collapsible:true});});})();
(function(){$(function(){
$('#accordion5').accordion({event:'mouseover'});});})();
(function(){$(function(){
$('#accordion4').accordion({event:'click hoverintent'});});})();
(function(){$(function(){
var $1_0={header:'ui-icon-circle-arrow-e',headerSelected:'ui-icon-circle-arrow-s'};$('#accordion7').accordion({icons:$1_0});$('#toggle').button();});})();
(function(){$(function(){
$('#accordion8').accordion({header:'> div > h3'}).sortable({axis:'y',handle:'h3',stop:function($p2_0,$p2_1){
$p2_1.item.children('h3').triggerHandler('focusout');}});});})();
(function(){$(function(){
$('#accordion2').accordion({fillSpace:true});$('#accordionResizer').resizable({minHeight:140,resize:function(){
$('#accordion2');}});});})();
(function(){$(function(){
$('#accordion1').accordion();});})();
(function(){$(function(){
var $1_0={};$1_0.source='Search';$1_0.minLength=2;$1_0.select=function($p2_0,$p2_1){
Sample.AutoComplete.jQueryUISample$5.$0(($p2_1.item!=null)?'Selected: '+($p2_1.item).value+' aka '+($p2_1.item).id:'Nothing selected, input was '+$(this).val());};$('#birds').autocomplete($1_0);});})();
(function(){$(function(){
var $1_0=['ActionScript','AppleScript','Asp','BASIC','C','C++','Clojure','COBOL','ColdFusion','Erlang','Fortran','Groovy','Haskell','Java','JavaScript','Lisp','Perl','PHP','Python','Ruby','Scala','Scheme'];$('#autocompleteTags').autocomplete({source:$1_0});});})();
(function(){$(function(){
});})();
(function(){$(function(){
$('.positionable').css('opacity','0.5');$(':input').bind('click keyup change',Sample.Position._Default.$0);$('#parent').draggable({drag:Sample.Position._Default.$0});Sample.Position._Default.$0(null);});})();
(function(){$(function(){
$('#sortable31, #sortable32').sortable({connectWith:'.connectedSortable'});});})();
(function(){$(function(){
$('#sortable41, #sortable42').sortable();var $1_0=$('#tabs').tabs();var $1_1=$('ul:first li',$1_0).droppable({accept:'.connectedSortable2 li',hoverClass:'ui-state-hover',drop:function($p2_0,$p2_1){
var $2_0=$($(this).find('a').attr('href')).find('.connectedSortable2');($p2_1.draggable).hide('slow',function(){
$1_0.tabs({active:$(this).index($(this).selector)});$(this).appendTo($2_0).show('slow');});}});});})();
(function(){$(function(){
$('.column').sortable({connectWith:'.column'});$('.portlet').addClass('ui-widget ui-widget-content ui-helper-clearfix ui-corner-all').find('.portlet-header').addClass('ui-widget-header ui-corner-all').prepend("<span class='ui-icon ui-icon-minusthick'></span>").end().find('.portlet-content');$('.portlet-header .ui-icon').click(function($p2_0){
$(this).toggleClass('ui-icon-minusthick').toggleClass('ui-icon-plusthick');$(this).parents('.portlet:first').find('.portlet-content').toggle();});});})();
(function(){$(function(){
$('#sortable8').sortable();});})();
(function(){$(function(){
$('#sortable71').sortable({delay:300});$('#sortable72').sortable({distance:15});});})();
(function(){$(function(){
$('#sortable61').sortable({items:'li:not(.ui-state-disabled)'});$('#sortable62').sortable({cancel:'.ui-state-disabled'});});})();
(function(){$(function(){
$('ul.droptrue').sortable({connectWith:'ul'});$('ul.dropfalse').sortable({connectWith:'ul',dropOnEmpty:false});});})();
(function(){$(function(){
$('#sortable2').sortable({placeholder:'ui-state-highlight'});});})();
(function(){$(function(){
$('#sortable1').sortable();});})();
(function(){$(function(){
$('#resizable9').resizable({animate:true});});})();
(function(){$(function(){
$('#resizable11').resizable({handles:'se'});});})();
(function(){$(function(){
$('#resizable10').resizable({helper:'ui-resizable-helper'});});})();
(function(){$(function(){
$('#resizable8').resizable({alsoResize:'#also'});$('#also').resizable();});})();
(function(){$(function(){
$('#resizable7').resizable({ghost:true});});})();
(function(){$(function(){
$('#resizable6').resizable({grid:50});});})();
(function(){$(function(){
$('#resizable51').resizable({delay:1000});$('#resizable52').resizable({distance:40});});})();
(function(){$(function(){
$('#resizable4').resizable({containment:'#container'});});})();
(function(){$(function(){
$('#resizable3').resizable({maxHeight:250,maxWidth:350,minHeight:150,minWidth:200});});})();
(function(){$(function(){
$('#resizable2').resizable({aspectRatio:16/9});});})();
(function(){$(function(){
$('#resizable1').resizable();});})();
(function(){$(function(){
$('#selectable3').selectable();});})();
(function(){$(function(){
$('#selectable2').selectable({stop:function($p2_0,$p2_1){
var $2_0=$('#select-result').empty();$('.ui-selected',$('#selectable2')).each(function($p3_0,$p3_1){
var $3_0=$('#selectable2 li').index($p3_1);$2_0.append(' #'+($3_0+1));});}});});})();
(function(){$(function(){
$('#selectable1').selectable();});})();
(function(){$(function(){
$('#draggableConstrain1').draggable({axis:'y'});$('#draggableConstrain2').draggable({axis:'x'});$('#draggableConstrain3').draggable({containment:'#containment-wrapper',scroll:false});$('#draggableConstrain4').draggable({containment:'#demo-frame'});$('#draggableConstrain5').draggable({containment:'parent'});});})();
(function(){$(function(){
var $1_0;$1_0={};$1_0.scroll=true;$('#draggableAutoScroll1').draggable($1_0);$1_0={};$1_0.scroll=true;$1_0.scrollSensitivity=100;$('#draggableAutoScroll2').draggable($1_0);$1_0={};$1_0.snap=true;$1_0.scrollSpeed=100;$('#draggableAutoScroll3').draggable($1_0);});})();
(function(){$(function(){
$('#sortable').sortable({revert:true});$('#draggableSortable').draggable({connectToSortable:'#sortable',helper:'clone',revert:'invalid'});$('ul, li').disableSelection();});})();
(function(){$(function(){
$('#draggableCursor1').draggable({cursor:'move',top:56,left:56});$('#draggableCursor2').draggable({cursor:'crosshair',top:-5,left:-5});$('#draggableCursor3').draggable({bottom:0});});})();
(function(){$(function(){
$('#draggableHandle1').draggable({handle:'p'});$('#draggableHandle2').draggable({cancel:'p.ui-widget-header'});$('div, p').disableSelection();});})();
(function(){$(function(){
$('#draggableVisual1').draggable({helper:'original'});$('#draggableVisual2').draggable({opacity:0.7,helper:'clone'});var $1_0={};$1_0.cursor='move';$1_0.cursorAt={top:-12,left:-20};$1_0.helper=function($p2_0){
return $("<div class='ui-widget-header'>I'm a custom helper</div>");};$('#draggableVisual3').draggable($1_0);$('#draggableVisualSet div').draggable({stack:'#draggableVisualSet div'});});})();
(function(){$(function(){
$('#draggableRevert1').draggable({revert:true});$('#draggableRevert2').draggable({revert:true,helper:'clone'});});})();
(function(){$(function(){
$('#draggableDefault').draggable();});})();
(function(){$(function(){
$('#draggableDelay').draggable({distance:20});$('#draggableDelay2').draggable({delay:1000});$('.ui-draggable').disableSelection();});})();
(function(){$(function(){
var $1_0=$('#event-start');var $1_1=$('#event-drag');var $1_2=$('#event-stop');var $1_3=[0,0,0];var $1_4={};$1_4.start=function($p2_0,$p2_1){
$1_3[0]++;Sample.Draggable._Events.$0($1_0,$1_3[0]);};$1_4.drag=function($p2_0,$p2_1){
$1_3[1]++;Sample.Draggable._Events.$0($1_1,$1_3[1]);};$1_4.stop=function($p2_0,$p2_1){
$1_3[2]++;Sample.Draggable._Events.$0($1_2,$1_3[2]);};$('#draggableEvents').draggable($1_4);});})();
(function(){$(function(){
$('#draggableSnap1').draggable({snap:true});$('#draggableSnap2').draggable({snap:'.ui-widget-header'});$('#draggableSnap3').draggable({snap:'.ui-widget-header',snapMode:'outer'});$('#draggableSnap4').draggable({grid:[20,20]});$('#draggableSnap5').draggable({grid:[80,80]});});})();
(function(){$(function(){
$('#draggableAcceptedElements, #draggable-nonvalid').draggable();$('#droppableAcceptedElements').droppable({accept:'#draggableAcceptedElements',activeClass:'ui-state-hover',hoverClass:'ui-state-active',drop:function($p2_0,$p2_1){
$(this).addClass('ui-state-highlight').find('p').html('Dropped!');}});});})();
(function(){$(function(){
$('#draggablePreventPropagation').draggable();var $1_0=function($p2_0,$p2_1){
$(this).addClass('ui-state-highlight').find('> p').html('Dropped!');};$('#droppablePreventPropagation1, #droppablePreventPropagation1-inner').droppable({activeClass:'ui-state-hover',hoverClass:'ui-state-active',drop:$1_0});$('#droppablePreventPropagation2, #droppablePreventPropagation2-inner').droppable({activeClass:'ui-state-hover',hoverClass:'ui-state-active',greedy:true,drop:$1_0});});})();
(function(){$(function(){
$('#draggableVisualFeedback1, #draggableVisualFeedback2').draggable();var $1_0=function($p2_0,$p2_1){
$(this).addClass('ui-state-highlight').find('p').html('Dropped!');};$('#droppableVisualFeedback1').droppable({hoverClass:'ui-state-active',drop:$1_0});$('#droppableVisualFeedback2').droppable({accept:'#draggableVisualFeedback2',activeClass:'ui-state-hover',drop:$1_0});});})();
(function(){$(function(){
$('#draggableRevert10').draggable({revert:'valid'});$('#draggableRevert20').draggable({revert:'invalid'});$('#droppableRevert10').droppable({activeClass:'ui-state-hover',hoverClass:'ui-state-active',drop:function($p2_0,$p2_1){
$(this).addClass('ui-state-highlight').find('p').html('Dropped!');}});});})();
(function(){$(function(){
$('#catalog').accordion();$('#catalog li').draggable({appendTo:'body',helper:'clone'});$('#cart ol').droppable({activeClass:'ui-state-default',hoverClass:'ui-state-hover',accept:':not(.ui-sortable-helper)',drop:function($p2_0,$p2_1){
$(this).find('.placeholder').remove();$('<li></li>').text($p2_1.draggable.text()).appendTo($(this));}}).sortable({items:'li:not(.placeholder)',sort:function(){
$(this).removeClass('ui-state-default');}});});})();
(function(){$(function(){
$('li',$('#gallery')).draggable({cancel:'a.ui-icon',revert:'invalid',containment:($('#demo-frame').length>0)?'#demo-frame':'document',helper:'clone',cursor:'move'});$('#trash').droppable({accept:'#gallery > li',activeClass:'ui-state-highlight',drop:function($p2_0,$p2_1){
Sample.Droppable._PhotoManager.$0($p2_1.draggable);}});$('#gallery').droppable({accept:'#trash li',activeClass:'custom-state-active',drop:function($p2_0,$p2_1){
Sample.Droppable._PhotoManager.$1($p2_1.draggable);}});$('ul.gallery > li').click(function($p2_0){
var $2_0=$(this);var $2_1=$($p2_0.target);if($2_1.is('a.ui-icon-trash')){Sample.Droppable._PhotoManager.$0($2_0);}else if($2_1.is('a.ui-icon-zoomin')){Sample.Droppable._PhotoManager.$2($2_1);}else if($2_1.is('a.ui-icon-refresh')){Sample.Droppable._PhotoManager.$1($2_0);}$p2_0.preventDefault();$p2_0.stopPropagation();});});})();
(function(){$(function(){
$('#droppableDraggableDefault').draggable();$('#droppableDroppableDefault').droppable({drop:function($p2_0,$p2_1){
$(this).addClass('ui-state-highlight').find('p').html('Dropped!');}});});})();
(function(){$(function(){
$('#progressbar3').progressbar({value:37});$('#progressbarWrapper').resizable();});})();
(function(){$(function(){
$('#progressbar2').progressbar({value:59});});})();
(function(){$(function(){
$('#progressbar1').progressbar({value:37});});})();
(function(){$(function(){
$.widget('custom.colorize',{options:{red:255,green:0,blue:0,change:null,random:null},_create:function(){
this.element.addClass('custom-colorize').disableSelection();this.changer=$('<button>',{text:'change','class':'custom-colorize-changer'}).appendTo(this.element).button();var $2_0=this;this.changer.bind('click.colorize',function($p3_0){
if(($2_0.options).disabled){return;}$2_0.random.apply($2_0,arguments);});this._refresh();},_refresh:function(){
this.element.css('background-color','rgb('+(this.options).red+','+(this.options).green+','+(this.options).blue+')');this._trigger('change');},random:function($p2_0){
var $2_0={red:Math.floor(Math.random()*256),green:Math.floor(Math.random()*256),blue:Math.floor(Math.random()*256)};if(this._trigger('random',$p2_0,$2_0)){this.option($2_0);}},destroy:function(){
this.changer.remove();this.element.removeClass('custom-colorize').enableSelection().css('background-color','transparent');},_setOptions:function(){
$.Widget.prototype._setOptions.apply(this,arguments);this._refresh();},_setOption:function($p2_0,$p2_1){
if(new RegExp('red|green|blue').test($p2_0)&&($p2_1<0||$p2_1>255)){return;}$.Widget.prototype._setOption.call(this,$p2_0,$p2_1);}});$('#my-widget1').colorize();$('#my-widget2').colorize({red:60,blue:60});$('#my-widget3').colorize({green:128,random:function($p2_0,$p2_1){
return $p2_1.green>128;}});$('#disable').toggle(function($p2_0){
$(':custom-colorize').colorize('disable');},function($p2_0){
$(':custom-colorize').colorize('enable');});$('#black').click(function($p2_0){
$(':custom-colorize').colorize('option',{red:0,green:0,blue:0});});});})();
})(jQuery);// This script was generated using Script# v0.7.4.0
