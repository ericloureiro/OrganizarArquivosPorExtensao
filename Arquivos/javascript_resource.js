function GetMessage(key) {
    var messages = Ext.decode(_hdnJavascriptResource.value);
    for (i = 0; i < messages.length; i++) {
        if (messages[i].Code == key) {
            return messages[i].Message;
        }
    }
    return '';
}