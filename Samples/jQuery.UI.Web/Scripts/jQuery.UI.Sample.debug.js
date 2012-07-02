//! jQuery.UI.Sample.debug.js
//

(function($) {

Type.registerNamespace('Sample.Accordion');

////////////////////////////////////////////////////////////////////////////////
// Sample.Accordion._noAuto

Sample.Accordion._noAuto = function Sample_Accordion__noAuto() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Accordion._collapse

Sample.Accordion._collapse = function Sample_Accordion__collapse() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Accordion._mouseOver

Sample.Accordion._mouseOver = function Sample_Accordion__mouseOver() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Accordion._hoverIntent

Sample.Accordion._hoverIntent = function Sample_Accordion__hoverIntent() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Accordion._icons

Sample.Accordion._icons = function Sample_Accordion__icons() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Accordion._sortable

Sample.Accordion._sortable = function Sample_Accordion__sortable() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Accordion._fillSpace

Sample.Accordion._fillSpace = function Sample_Accordion__fillSpace() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Accordion._default

Sample.Accordion._default = function Sample_Accordion__default() {
}


Type.registerNamespace('Sample.AutoComplete');

////////////////////////////////////////////////////////////////////////////////
// Sample.AutoComplete._remoteDatasource

Sample.AutoComplete._remoteDatasource = function Sample_AutoComplete__remoteDatasource() {
}
Sample.AutoComplete._remoteDatasource._log = function Sample_AutoComplete__remoteDatasource$_log(message) {
    /// <param name="message" type="String">
    /// </param>
    $('<div/>').text(message).prependTo('#log');
    $('#log').scrollTop(0);
}


////////////////////////////////////////////////////////////////////////////////
// Sample.AutoComplete._default

Sample.AutoComplete._default = function Sample_AutoComplete__default() {
}


Type.registerNamespace('Sample.Position');

////////////////////////////////////////////////////////////////////////////////
// Sample.Position._cycling

Sample.Position._cycling = function Sample_Position__cycling() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Position._default

Sample.Position._default = function Sample_Position__default() {
}
Sample.Position._default._position = function Sample_Position__default$_position(e) {
    /// <param name="e" type="jQueryEvent">
    /// </param>
    $('.positionable').position({ my: $('#my_horizontal').val() + ' ' + $('#my_vertical').val(), at: $('#at_horizontal').val() + ' ' + $('#at_vertical').val(), offset: $('#offset').val(), collision: $('#collision_horizontal').val() + ' ' + $('#collision_vertical').val() });
}


Type.registerNamespace('Sample.Sortable');

////////////////////////////////////////////////////////////////////////////////
// Sample.Sortable._connectLists

Sample.Sortable._connectLists = function Sample_Sortable__connectLists() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Sortable._connectListsTabs

Sample.Sortable._connectListsTabs = function Sample_Sortable__connectListsTabs() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Sortable._portlets

Sample.Sortable._portlets = function Sample_Sortable__portlets() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Sortable._dispalyAsGrid

Sample.Sortable._dispalyAsGrid = function Sample_Sortable__dispalyAsGrid() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Sortable._delayStart

Sample.Sortable._delayStart = function Sample_Sortable__delayStart() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Sortable._includeExclude

Sample.Sortable._includeExclude = function Sample_Sortable__includeExclude() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Sortable._emptyLists

Sample.Sortable._emptyLists = function Sample_Sortable__emptyLists() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Sortable._dropPlaceholder

Sample.Sortable._dropPlaceholder = function Sample_Sortable__dropPlaceholder() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Sortable._default

Sample.Sortable._default = function Sample_Sortable__default() {
}


Type.registerNamespace('Sample.Resizable');

////////////////////////////////////////////////////////////////////////////////
// Sample.Resizable._animate

Sample.Resizable._animate = function Sample_Resizable__animate() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Resizable._textarea

Sample.Resizable._textarea = function Sample_Resizable__textarea() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Resizable._resizeHelper

Sample.Resizable._resizeHelper = function Sample_Resizable__resizeHelper() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Resizable._synchronousResize

Sample.Resizable._synchronousResize = function Sample_Resizable__synchronousResize() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Resizable._visualFeedback

Sample.Resizable._visualFeedback = function Sample_Resizable__visualFeedback() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Resizable._snapToGrid

Sample.Resizable._snapToGrid = function Sample_Resizable__snapToGrid() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Resizable._delayStart

Sample.Resizable._delayStart = function Sample_Resizable__delayStart() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Resizable._resizeArea

Sample.Resizable._resizeArea = function Sample_Resizable__resizeArea() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Resizable._maxMinSize

Sample.Resizable._maxMinSize = function Sample_Resizable__maxMinSize() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Resizable._preserveAspectRatio

Sample.Resizable._preserveAspectRatio = function Sample_Resizable__preserveAspectRatio() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Resizable._default

Sample.Resizable._default = function Sample_Resizable__default() {
}


Type.registerNamespace('Sample.Selectable');

////////////////////////////////////////////////////////////////////////////////
// Sample.Selectable._displayAsGrid

Sample.Selectable._displayAsGrid = function Sample_Selectable__displayAsGrid() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Selectable._serialize

Sample.Selectable._serialize = function Sample_Selectable__serialize() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Selectable._default

Sample.Selectable._default = function Sample_Selectable__default() {
}


Type.registerNamespace('Sample.Draggable');

////////////////////////////////////////////////////////////////////////////////
// Sample.Draggable._constrainMovement

Sample.Draggable._constrainMovement = function Sample_Draggable__constrainMovement() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Draggable._autoScroll

Sample.Draggable._autoScroll = function Sample_Draggable__autoScroll() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Draggable._draggableSortable

Sample.Draggable._draggableSortable = function Sample_Draggable__draggableSortable() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Draggable._cursorStyle

Sample.Draggable._cursorStyle = function Sample_Draggable__cursorStyle() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Draggable._dragHandle

Sample.Draggable._dragHandle = function Sample_Draggable__dragHandle() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Draggable._visualFeedback

Sample.Draggable._visualFeedback = function Sample_Draggable__visualFeedback() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Draggable._revertPosition

Sample.Draggable._revertPosition = function Sample_Draggable__revertPosition() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Draggable._default

Sample.Draggable._default = function Sample_Draggable__default() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Draggable._delayStart

Sample.Draggable._delayStart = function Sample_Draggable__delayStart() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Draggable._events

Sample.Draggable._events = function Sample_Draggable__events() {
}
Sample.Draggable._events._updateCounterStatus = function Sample_Draggable__events$_updateCounterStatus(event_counter, new_count) {
    /// <param name="event_counter" type="jQueryObject">
    /// </param>
    /// <param name="new_count" type="Number" integer="true">
    /// </param>
    if (!event_counter.hasClass('ui-state-hover')) {
        event_counter.addClass('ui-state-hover').siblings().removeClass('ui-state-hover');
    }
    $('span.count', event_counter).text(new_count.toString());
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Draggable._snap

Sample.Draggable._snap = function Sample_Draggable__snap() {
}


Type.registerNamespace('Sample.Droppable');

////////////////////////////////////////////////////////////////////////////////
// Sample.Droppable._acceptedElements

Sample.Droppable._acceptedElements = function Sample_Droppable__acceptedElements() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Droppable._preventPropagation

Sample.Droppable._preventPropagation = function Sample_Droppable__preventPropagation() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Droppable._visualFeedback

Sample.Droppable._visualFeedback = function Sample_Droppable__visualFeedback() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Droppable._revert

Sample.Droppable._revert = function Sample_Droppable__revert() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Droppable._shoppingCart

Sample.Droppable._shoppingCart = function Sample_Droppable__shoppingCart() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Droppable._photoManager

Sample.Droppable._photoManager = function Sample_Droppable__photoManager() {
}
Sample.Droppable._photoManager._deleteImage = function Sample_Droppable__photoManager$_deleteImage(item) {
    /// <param name="item" type="jQueryObject">
    /// </param>
    var recycle_icon = "<a href='link/to/recycle/script/when/we/have/js/off' title='Recycle this image' class='ui-icon ui-icon-refresh'>Recycle image</a>";
    item.fadeOut('slow', function() {
        var list = ($('ul', $('#trash')).length > 0) ? $('ul', $('#trash')) : $("<ul class='gallery ui-helper-reset'/>").appendTo('#trash');
        item.find('a.ui-icon-trash').remove();
        item.append(recycle_icon).appendTo(list).fadeIn('slow', function() {
            item.animate({ width: '48px' }).find('img').animate({ height: '36px' });
        });
    });
}
Sample.Droppable._photoManager._recycleImage = function Sample_Droppable__photoManager$_recycleImage(item) {
    /// <param name="item" type="jQueryObject">
    /// </param>
    var trash_icon = "<a href='link/to/trash/script/when/we/have/js/off' title='Delete this image' class='ui-icon ui-icon-trash'>Delete image</a>";
    item.fadeOut('slow', function() {
        item.find('a.ui-icon-refresh').remove().end().css('width', '96px').append(trash_icon).find('img').css('height', '72px').end().appendTo('#gallery').fadeIn();
    });
}
Sample.Droppable._photoManager._viewLargerImage = function Sample_Droppable__photoManager$_viewLargerImage(link) {
    /// <param name="link" type="jQueryObject">
    /// </param>
    var src = link.attr('href');
    var title = link.siblings('img').attr('alt');
    var modal = $("img[src$='" + src + "']");
    if (modal.length > 0) {
        modal.dialog('open');
    }
    else {
        var img = $("<img alt='" + title + "' width='384' height='288' style='display: none; padding: 8px;' />").attr('src', src).appendTo('body');
        img.dialog({ title: title, width: 400, modal: true });
    }
}


////////////////////////////////////////////////////////////////////////////////
// Sample.Droppable._default

Sample.Droppable._default = function Sample_Droppable__default() {
}


Type.registerNamespace('Sample.ProgressBar');

////////////////////////////////////////////////////////////////////////////////
// Sample.ProgressBar._resizableBar

Sample.ProgressBar._resizableBar = function Sample_ProgressBar__resizableBar() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.ProgressBar._animated

Sample.ProgressBar._animated = function Sample_ProgressBar__animated() {
}


////////////////////////////////////////////////////////////////////////////////
// Sample.ProgressBar._default

Sample.ProgressBar._default = function Sample_ProgressBar__default() {
}


Type.registerNamespace('Sample.Widget');

////////////////////////////////////////////////////////////////////////////////
// Sample.Widget._default

Sample.Widget._default = function Sample_Widget__default() {
}


Sample.Accordion._noAuto.registerClass('Sample.Accordion._noAuto');
Sample.Accordion._collapse.registerClass('Sample.Accordion._collapse');
Sample.Accordion._mouseOver.registerClass('Sample.Accordion._mouseOver');
Sample.Accordion._hoverIntent.registerClass('Sample.Accordion._hoverIntent');
Sample.Accordion._icons.registerClass('Sample.Accordion._icons');
Sample.Accordion._sortable.registerClass('Sample.Accordion._sortable');
Sample.Accordion._fillSpace.registerClass('Sample.Accordion._fillSpace');
Sample.Accordion._default.registerClass('Sample.Accordion._default');
Sample.AutoComplete._remoteDatasource.registerClass('Sample.AutoComplete._remoteDatasource');
Sample.AutoComplete._default.registerClass('Sample.AutoComplete._default');
Sample.Position._cycling.registerClass('Sample.Position._cycling');
Sample.Position._default.registerClass('Sample.Position._default');
Sample.Sortable._connectLists.registerClass('Sample.Sortable._connectLists');
Sample.Sortable._connectListsTabs.registerClass('Sample.Sortable._connectListsTabs');
Sample.Sortable._portlets.registerClass('Sample.Sortable._portlets');
Sample.Sortable._dispalyAsGrid.registerClass('Sample.Sortable._dispalyAsGrid');
Sample.Sortable._delayStart.registerClass('Sample.Sortable._delayStart');
Sample.Sortable._includeExclude.registerClass('Sample.Sortable._includeExclude');
Sample.Sortable._emptyLists.registerClass('Sample.Sortable._emptyLists');
Sample.Sortable._dropPlaceholder.registerClass('Sample.Sortable._dropPlaceholder');
Sample.Sortable._default.registerClass('Sample.Sortable._default');
Sample.Resizable._animate.registerClass('Sample.Resizable._animate');
Sample.Resizable._textarea.registerClass('Sample.Resizable._textarea');
Sample.Resizable._resizeHelper.registerClass('Sample.Resizable._resizeHelper');
Sample.Resizable._synchronousResize.registerClass('Sample.Resizable._synchronousResize');
Sample.Resizable._visualFeedback.registerClass('Sample.Resizable._visualFeedback');
Sample.Resizable._snapToGrid.registerClass('Sample.Resizable._snapToGrid');
Sample.Resizable._delayStart.registerClass('Sample.Resizable._delayStart');
Sample.Resizable._resizeArea.registerClass('Sample.Resizable._resizeArea');
Sample.Resizable._maxMinSize.registerClass('Sample.Resizable._maxMinSize');
Sample.Resizable._preserveAspectRatio.registerClass('Sample.Resizable._preserveAspectRatio');
Sample.Resizable._default.registerClass('Sample.Resizable._default');
Sample.Selectable._displayAsGrid.registerClass('Sample.Selectable._displayAsGrid');
Sample.Selectable._serialize.registerClass('Sample.Selectable._serialize');
Sample.Selectable._default.registerClass('Sample.Selectable._default');
Sample.Draggable._constrainMovement.registerClass('Sample.Draggable._constrainMovement');
Sample.Draggable._autoScroll.registerClass('Sample.Draggable._autoScroll');
Sample.Draggable._draggableSortable.registerClass('Sample.Draggable._draggableSortable');
Sample.Draggable._cursorStyle.registerClass('Sample.Draggable._cursorStyle');
Sample.Draggable._dragHandle.registerClass('Sample.Draggable._dragHandle');
Sample.Draggable._visualFeedback.registerClass('Sample.Draggable._visualFeedback');
Sample.Draggable._revertPosition.registerClass('Sample.Draggable._revertPosition');
Sample.Draggable._default.registerClass('Sample.Draggable._default');
Sample.Draggable._delayStart.registerClass('Sample.Draggable._delayStart');
Sample.Draggable._events.registerClass('Sample.Draggable._events');
Sample.Draggable._snap.registerClass('Sample.Draggable._snap');
Sample.Droppable._acceptedElements.registerClass('Sample.Droppable._acceptedElements');
Sample.Droppable._preventPropagation.registerClass('Sample.Droppable._preventPropagation');
Sample.Droppable._visualFeedback.registerClass('Sample.Droppable._visualFeedback');
Sample.Droppable._revert.registerClass('Sample.Droppable._revert');
Sample.Droppable._shoppingCart.registerClass('Sample.Droppable._shoppingCart');
Sample.Droppable._photoManager.registerClass('Sample.Droppable._photoManager');
Sample.Droppable._default.registerClass('Sample.Droppable._default');
Sample.ProgressBar._resizableBar.registerClass('Sample.ProgressBar._resizableBar');
Sample.ProgressBar._animated.registerClass('Sample.ProgressBar._animated');
Sample.ProgressBar._default.registerClass('Sample.ProgressBar._default');
Sample.Widget._default.registerClass('Sample.Widget._default');
(function () {
    $(function() {
        $('#accordion3').accordion({ autoHeight: false, navigation: true });
    });
})();
(function () {
    $(function() {
        $('#accordion4').accordion({ collapsible: true });
    });
})();
(function () {
    $(function() {
        $('#accordion5').accordion({ event: 'mouseover' });
    });
})();
(function () {
    $(function() {
        $('#accordion4').accordion({ event: 'click hoverintent' });
    });
})();
(function () {
    $(function() {
        var icons = { header: 'ui-icon-circle-arrow-e', headerSelected: 'ui-icon-circle-arrow-s' };
        $('#accordion7').accordion({ icons: icons });
        $('#toggle').button();
    });
})();
(function () {
    $(function() {
        $('#accordion8').accordion({ header: '> div > h3' }).sortable({ axis: 'y', handle: 'h3', stop: function(eevent, ui) {
            ui.item.children('h3').triggerHandler('focusout');
        } });
    });
})();
(function () {
    $(function() {
        $('#accordion2').accordion({ fillSpace: true });
        $('#accordionResizer').resizable({ minHeight: 140, resize: function() {
            $('#accordion2');
        } });
    });
})();
(function () {
    $(function() {
        $('#accordion1').accordion();
    });
})();
(function () {
    $(function() {
        var options = {};
        options.source = 'Search';
        options.minLength = 2;
        options.select = function(e, ui) {
            Sample.AutoComplete._remoteDatasource._log((ui.item != null) ? 'Selected: ' + (ui.item).value + ' aka ' + (ui.item).id : 'Nothing selected, input was ' + $(this).val());
        };
        $('#birds').autocomplete(options);
    });
})();
(function () {
    $(function() {
        var availableTags = [ 'ActionScript', 'AppleScript', 'Asp', 'BASIC', 'C', 'C++', 'Clojure', 'COBOL', 'ColdFusion', 'Erlang', 'Fortran', 'Groovy', 'Haskell', 'Java', 'JavaScript', 'Lisp', 'Perl', 'PHP', 'Python', 'Ruby', 'Scala', 'Scheme' ];
        $('#autocompleteTags').autocomplete({ source: availableTags });
    });
})();
(function () {
    $(function() {
    });
})();
(function () {
    $(function() {
        $('.positionable').css('opacity', '0.5');
        $(':input').bind('click keyup change', Sample.Position._default._position);
        $('#parent').draggable({ drag: Sample.Position._default._position });
        Sample.Position._default._position(null);
    });
})();
(function () {
    $(function() {
        $('#sortable31, #sortable32').sortable({ connectWith: '.connectedSortable' });
    });
})();
(function () {
    $(function() {
        $('#sortable41, #sortable42').sortable();
        var tabs = $('#tabs').tabs();
        var tabItems = $('ul:first li', tabs).droppable({ accept: '.connectedSortable2 li', hoverClass: 'ui-state-hover', drop: function(e, dropEvent) {
            var list = $($(this).find('a').attr('href')).find('.connectedSortable2');
            (dropEvent.draggable).hide('slow', function() {
                tabs.tabs({ active: $(this).index($(this).selector) });
                $(this).appendTo(list).show('slow');
            });
        } });
    });
})();
(function () {
    $(function() {
        $('.column').sortable({ connectWith: '.column' });
        $('.portlet').addClass('ui-widget ui-widget-content ui-helper-clearfix ui-corner-all').find('.portlet-header').addClass('ui-widget-header ui-corner-all').prepend("<span class='ui-icon ui-icon-minusthick'></span>").end().find('.portlet-content');
        $('.portlet-header .ui-icon').click(function(e) {
            $(this).toggleClass('ui-icon-minusthick').toggleClass('ui-icon-plusthick');
            $(this).parents('.portlet:first').find('.portlet-content').toggle();
        });
    });
})();
(function () {
    $(function() {
        $('#sortable8').sortable();
    });
})();
(function () {
    $(function() {
        $('#sortable71').sortable({ delay: 300 });
        $('#sortable72').sortable({ distance: 15 });
    });
})();
(function () {
    $(function() {
        $('#sortable61').sortable({ items: 'li:not(.ui-state-disabled)' });
        $('#sortable62').sortable({ cancel: '.ui-state-disabled' });
    });
})();
(function () {
    $(function() {
        $('ul.droptrue').sortable({ connectWith: 'ul' });
        $('ul.dropfalse').sortable({ connectWith: 'ul', dropOnEmpty: false });
    });
})();
(function () {
    $(function() {
        $('#sortable2').sortable({ placeholder: 'ui-state-highlight' });
    });
})();
(function () {
    $(function() {
        $('#sortable1').sortable();
    });
})();
(function () {
    $(function() {
        $('#resizable9').resizable({ animate: true });
    });
})();
(function () {
    $(function() {
        $('#resizable11').resizable({ handles: 'se' });
    });
})();
(function () {
    $(function() {
        $('#resizable10').resizable({ helper: 'ui-resizable-helper' });
    });
})();
(function () {
    $(function() {
        $('#resizable8').resizable({ alsoResize: '#also' });
        $('#also').resizable();
    });
})();
(function () {
    $(function() {
        $('#resizable7').resizable({ ghost: true });
    });
})();
(function () {
    $(function() {
        $('#resizable6').resizable({ grid: 50 });
    });
})();
(function () {
    $(function() {
        $('#resizable51').resizable({ delay: 1000 });
        $('#resizable52').resizable({ distance: 40 });
    });
})();
(function () {
    $(function() {
        $('#resizable4').resizable({ containment: '#container' });
    });
})();
(function () {
    $(function() {
        $('#resizable3').resizable({ maxHeight: 250, maxWidth: 350, minHeight: 150, minWidth: 200 });
    });
})();
(function () {
    $(function() {
        $('#resizable2').resizable({ aspectRatio: 16 / 9 });
    });
})();
(function () {
    $(function() {
        $('#resizable1').resizable();
    });
})();
(function () {
    $(function() {
        $('#selectable3').selectable();
    });
})();
(function () {
    $(function() {
        $('#selectable2').selectable({ stop: function(e, uiEvent) {
            var result = $('#select-result').empty();
            $('.ui-selected', $('#selectable2')).each(function(idx, element) {
                var index = $('#selectable2 li').index(element);
                result.append(' #' + (index + 1));
            });
        } });
    });
})();
(function () {
    $(function() {
        $('#selectable1').selectable();
    });
})();
(function () {
    $(function() {
        $('#draggableConstrain1').draggable({ axis: 'y' });
        $('#draggableConstrain2').draggable({ axis: 'x' });
        $('#draggableConstrain3').draggable({ containment: '#containment-wrapper', scroll: false });
        $('#draggableConstrain4').draggable({ containment: '#demo-frame' });
        $('#draggableConstrain5').draggable({ containment: 'parent' });
    });
})();
(function () {
    $(function() {
        var options;
        options = {};
        options.scroll = true;
        $('#draggableAutoScroll1').draggable(options);
        options = {};
        options.scroll = true;
        options.scrollSensitivity = 100;
        $('#draggableAutoScroll2').draggable(options);
        options = {};
        options.snap = true;
        options.scrollSpeed = 100;
        $('#draggableAutoScroll3').draggable(options);
    });
})();
(function () {
    $(function() {
        $('#sortable').sortable({ revert: true });
        $('#draggableSortable').draggable({ connectToSortable: '#sortable', helper: 'clone', revert: 'invalid' });
        $('ul, li').disableSelection();
    });
})();
(function () {
    $(function() {
        $('#draggableCursor1').draggable({ cursor: 'move', top: 56, left: 56 });
        $('#draggableCursor2').draggable({ cursor: 'crosshair', top: -5, left: -5 });
        $('#draggableCursor3').draggable({ bottom: 0 });
    });
})();
(function () {
    $(function() {
        $('#draggableHandle1').draggable({ handle: 'p' });
        $('#draggableHandle2').draggable({ cancel: 'p.ui-widget-header' });
        $('div, p').disableSelection();
    });
})();
(function () {
    $(function() {
        $('#draggableVisual1').draggable({ helper: 'original' });
        $('#draggableVisual2').draggable({ opacity: 0.7, helper: 'clone' });
        var options = {};
        options.cursor = 'move';
        options.cursorAt = { top: -12, left: -20 };
        options.helper = function(e) {
            return $("<div class='ui-widget-header'>I'm a custom helper</div>");
        };
        $('#draggableVisual3').draggable(options);
        $('#draggableVisualSet div').draggable({ stack: '#draggableVisualSet div' });
    });
})();
(function () {
    $(function() {
        $('#draggableRevert1').draggable({ revert: true });
        $('#draggableRevert2').draggable({ revert: true, helper: 'clone' });
    });
})();
(function () {
    $(function() {
        $('#draggableDefault').draggable();
    });
})();
(function () {
    $(function() {
        $('#draggableDelay').draggable({ distance: 20 });
        $('#draggableDelay2').draggable({ delay: 1000 });
        $('.ui-draggable').disableSelection();
    });
})();
(function () {
    $(function() {
        var start_counter = $('#event-start');
        var drag_counter = $('#event-drag');
        var stop_counter = $('#event-stop');
        var counts = [ 0, 0, 0 ];
        var options = {};
        options.start = function(e, eventData) {
            counts[0]++;
            Sample.Draggable._events._updateCounterStatus(start_counter, counts[0]);
        };
        options.drag = function(e, eventData) {
            counts[1]++;
            Sample.Draggable._events._updateCounterStatus(drag_counter, counts[1]);
        };
        options.stop = function(e, eventData) {
            counts[2]++;
            Sample.Draggable._events._updateCounterStatus(stop_counter, counts[2]);
        };
        $('#draggableEvents').draggable(options);
    });
})();
(function () {
    $(function() {
        $('#draggableSnap1').draggable({ snap: true });
        $('#draggableSnap2').draggable({ snap: '.ui-widget-header' });
        $('#draggableSnap3').draggable({ snap: '.ui-widget-header', snapMode: 'outer' });
        $('#draggableSnap4').draggable({ grid: [ 20, 20 ] });
        $('#draggableSnap5').draggable({ grid: [ 80, 80 ] });
    });
})();
(function () {
    $(function() {
        $('#draggableAcceptedElements, #draggable-nonvalid').draggable();
        $('#droppableAcceptedElements').droppable({ accept: '#draggableAcceptedElements', activeClass: 'ui-state-hover', hoverClass: 'ui-state-active', drop: function(e, ui) {
            $(this).addClass('ui-state-highlight').find('p').html('Dropped!');
        } });
    });
})();
(function () {
    $(function() {
        $('#draggablePreventPropagation').draggable();
        var drop = function(e, ui) {
            $(this).addClass('ui-state-highlight').find('> p').html('Dropped!');
        };
        $('#droppablePreventPropagation1, #droppablePreventPropagation1-inner').droppable({ activeClass: 'ui-state-hover', hoverClass: 'ui-state-active', drop: drop });
        $('#droppablePreventPropagation2, #droppablePreventPropagation2-inner').droppable({ activeClass: 'ui-state-hover', hoverClass: 'ui-state-active', greedy: true, drop: drop });
    });
})();
(function () {
    $(function() {
        $('#draggableVisualFeedback1, #draggableVisualFeedback2').draggable();
        var drop = function(e, ui) {
            $(this).addClass('ui-state-highlight').find('p').html('Dropped!');
        };
        $('#droppableVisualFeedback1').droppable({ hoverClass: 'ui-state-active', drop: drop });
        $('#droppableVisualFeedback2').droppable({ accept: '#draggableVisualFeedback2', activeClass: 'ui-state-hover', drop: drop });
    });
})();
(function () {
    $(function() {
        $('#draggableRevert10').draggable({ revert: 'valid' });
        $('#draggableRevert20').draggable({ revert: 'invalid' });
        $('#droppableRevert10').droppable({ activeClass: 'ui-state-hover', hoverClass: 'ui-state-active', drop: function(e, ui) {
            $(this).addClass('ui-state-highlight').find('p').html('Dropped!');
        } });
    });
})();
(function () {
    $(function() {
        $('#catalog').accordion();
        $('#catalog li').draggable({ appendTo: 'body', helper: 'clone' });
        $('#cart ol').droppable({ activeClass: 'ui-state-default', hoverClass: 'ui-state-hover', accept: ':not(.ui-sortable-helper)', drop: function(e, ui) {
            $(this).find('.placeholder').remove();
            $('<li></li>').text(ui.draggable.text()).appendTo($(this));
        } }).sortable({ items: 'li:not(.placeholder)', sort: function() {
            $(this).removeClass('ui-state-default');
        } });
    });
})();
(function () {
    $(function() {
        $('li', $('#gallery')).draggable({ cancel: 'a.ui-icon', revert: 'invalid', containment: ($('#demo-frame').length > 0) ? '#demo-frame' : 'document', helper: 'clone', cursor: 'move' });
        $('#trash').droppable({ accept: '#gallery > li', activeClass: 'ui-state-highlight', drop: function(e, ui) {
            Sample.Droppable._photoManager._deleteImage(ui.draggable);
        } });
        $('#gallery').droppable({ accept: '#trash li', activeClass: 'custom-state-active', drop: function(e, ui) {
            Sample.Droppable._photoManager._recycleImage(ui.draggable);
        } });
        $('ul.gallery > li').click(function(e) {
            var item = $(this);
            var target = $(e.target);
            if (target.is('a.ui-icon-trash')) {
                Sample.Droppable._photoManager._deleteImage(item);
            }
            else if (target.is('a.ui-icon-zoomin')) {
                Sample.Droppable._photoManager._viewLargerImage(target);
            }
            else if (target.is('a.ui-icon-refresh')) {
                Sample.Droppable._photoManager._recycleImage(item);
            }
            e.preventDefault();
            e.stopPropagation();
        });
    });
})();
(function () {
    $(function() {
        $('#droppableDraggableDefault').draggable();
        $('#droppableDroppableDefault').droppable({ drop: function(e, ui) {
            $(this).addClass('ui-state-highlight').find('p').html('Dropped!');
        } });
    });
})();
(function () {
    $(function() {
        $('#progressbar3').progressbar({ value: 37 });
        $('#progressbarWrapper').resizable();
    });
})();
(function () {
    $(function() {
        $('#progressbar2').progressbar({ value: 59 });
    });
})();
(function () {
    $(function() {
        $('#progressbar1').progressbar({ value: 37 });
    });
})();
(function () {
    $(function() {
        $.widget('custom.colorize', { options: { red: 255, green: 0, blue: 0, change: null, random: null }, _create: function() {
            this.element.addClass('custom-colorize').disableSelection();
            this.changer = $('<button>', { text: 'change', 'class': 'custom-colorize-changer' }).appendTo(this.element).button();
            var that = this;
            this.changer.bind('click.colorize', function(e) {
                if ((that.options).disabled) {
                    return;
                }
                that.random.apply(that, arguments);
            });
            this._refresh();
        }, _refresh: function() {
            this.element.css('background-color', 'rgb(' + (this.options).red + ',' + (this.options).green + ',' + (this.options).blue + ')');
            this._trigger('change');
        }, random: function(e) {
            var colors = { red: Math.floor(Math.random() * 256), green: Math.floor(Math.random() * 256), blue: Math.floor(Math.random() * 256) };
            if (this._trigger('random', e, colors)) {
                this.option(colors);
            }
        }, destroy: function() {
            this.changer.remove();
            this.element.removeClass('custom-colorize').enableSelection().css('background-color', 'transparent');
        }, _setOptions: function() {
            $.Widget.prototype._setOptions.apply(this, arguments);
            this._refresh();
        }, _setOption: function(key, value) {
            if (new RegExp('red|green|blue').test(key) && (value < 0 || value > 255)) {
                return;
            }
            $.Widget.prototype._setOption.call(this, key, value);
        } });
        $('#my-widget1').colorize();
        $('#my-widget2').colorize({ red: 60, blue: 60 });
        $('#my-widget3').colorize({ green: 128, random: function(e, ui) {
            return ui.green > 128;
        } });
        $('#disable').toggle(function(e) {
            $(':custom-colorize').colorize('disable');
        }, function(e) {
            $(':custom-colorize').colorize('enable');
        });
        $('#black').click(function(e) {
            $(':custom-colorize').colorize('option', { red: 0, green: 0, blue: 0 });
        });
    });
})();
})(jQuery);

//! This script was generated using Script# v0.7.4.0
