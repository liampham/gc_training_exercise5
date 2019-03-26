//Chart Types Module
function typeMenu_SelectedIndexChanged(sender) {
    if (sender.selectedValue) {
        var chartTypes = wijmo.Control.getControl("#chartTypes");
        if (chartTypes) chartTypes.chartType = sender.selectedValue;
    }
}

function stackingMenu_SelectedIndexChanged(sender) {
    if (sender.selectedValue) {
        var chartTypes = wijmo.Control.getControl("#chartTypes");
        if (chartTypes) chartTypes.stacking = parseInt(sender.selectedIndex);//sender.selectedValue;
    }
}

function rotatedMenu_SelectedIndexChanged(sender) {
    if (sender.selectedValue) {
        var chartTypes = wijmo.Control.getControl("#chartTypes");
        if (chartTypes) chartTypes.rotated = sender.selectedValue == 'True' ? true : false;
    }
}
