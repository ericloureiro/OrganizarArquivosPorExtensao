Ext.override(Ext.grid.GridPanel, {
    selectAllInAllPages: function () {
        var grid = this,
        store = grid.getStore(),
        idProperty = grid.getStore().reader.meta.idProperty,
        id;

        Ext.each(store.getAllRange(), function (rec, index) {
            id = rec.data[idProperty];

            grid.selectedIds[id] = {
                id: id,
                index: index
            };
        });

        grid.getSelectionModel().selectAll();
    }
    ,
    deselectAllInAllPages: function () {
        var grid = this;

        grid.selectedIds = [];
        grid.getSelectionModel().deselectRange(0, grid.store.autoLoad.params.limit);
    }
});

function showWarning(message) {
    Ext.Msg.show({
        autoHide: true,
        msg: message,
        icon: Ext.MessageBox.WARNING,
        buttons: Ext.Msg.OK,
        hideFx: {
            args: ['t', {}],
            fxName: 'ghost'
        },
        showFx: {
            args: ['t', {}],
            fxName: 'ghost'
        },
        alignToCfg: {
            offset: [-20, 20],
            position: 'c-c'
        },
        html: message,
        title: ''
    });
}

Ext.override(Ext.form.Field, {
    originalClear: Ext.form.Field.prototype.clear,
    clear: function () {
        this.originalClear.apply(this);
        this.clearInvalid();
    }
});

Ext.override(Ext.form.TextField, {
    originalDisable: Ext.Button.prototype.disable,
    originalEnable: Ext.Button.prototype.enable,
    disable: function () {
        if (this.rendered) {
            if (Ext.isIE) { this.el.dom.unselectable = "on" }

            this.el.dom.style.backgroundColor = "WhiteSmoke";
        }

        this.disabled = true;
        this.fireEvent("disable", this);

        disableAndEnableTabIndex(this.id, false);

        setDomAttribute(this.id, "readOnly", true);
    },
    totalDisable: function (silent) {
        if (this.rendered) {
            this.onDisable();

            this.el.dom.style.backgroundColor = "WhiteSmoke";
        }
        this.disabled = true;
        if (silent !== true) {
            this.fireEvent('disable', this);
        }
        return this;
    },


    totalEnable: function (silent) {
        if (this.rendered) {
            this.onEnable();

            this.el.dom.style.backgroundColor = "White";
        }
        this.disabled = false;
        if (silent !== true) {
            this.fireEvent('enable', this);
        }
        return this;
    },

    enable: function () {
        if (this.rendered) {
            if (Ext.isIE) { this.el.dom.unselectable = "" }

            this.el.dom.style.backgroundColor = "White";
        }

        this.disabled = false;
        this.fireEvent("enable", this);

        disableAndEnableTabIndex(this.id, true);

        setDomAttribute(this.id, "readOnly", false);
    },
});

Ext.override(Ext.Button, {
    originalDisable: Ext.Button.prototype.disable,
    originalEnable: Ext.Button.prototype.enable,
    //disable: function () {
    //    this.originalDisable.apply(this);
    //    if (this.btnEl) {
    //        this.btnEl.dom.disabled = true;
    //    }
    //},
    //enable: function () {
    //    this.originalEnable.apply(this);
    //    if (this.btnEl) {
    //        this.btnEl.dom.disabled = false;
    //    }
    //}
});

function disableAndEnableTabIndex(comp, enableField) {
    var component = Ext.getCmp(comp);

    if (component) {
        var newTabIndex = 0;

        if (enableField) {
            newTabIndex = component.oldTabIndex;
        }
        else {
            if (component.tabIndex != -1) {
                component.oldTabIndex = component.tabIndex;
            }
            newTabIndex = -1;
        }

        component.tabIndex = newTabIndex;

        setDomAttribute(component.id, 'tabIndex', newTabIndex);
    }
}

function setDomAttribute(comp, attribute, value) {
    var component = Ext.getCmp(comp);

    if (component && component.el && component.el.dom) {
        eval('component.el.dom.' + attribute + ' = ' + value + ';')
    }
}

var onBeforeAjaxRequestMXM = function (a, b, c, d, e, f) {

    try{
        if (a && a.el && a.el.id) {
            //Remove o foco do botão, para impedir que ocorram vários postbacks se o usuário apertar o enter várias vezes
            var disabledButton = Ext.getCmp(a.el.id);
            if (disabledButton && disabledButton.isXType('button')) {
                disabledButton.blur();
            }
        }
    }catch(ex){ }

    removeDangerousChars();

    //Permite ao desenvolvedor criar uma rotina específica para uma página
    if (typeof specificBeforeAjaxRoutine === 'function') {
        specificBeforeAjaxRoutine(a, b, c, d, e, f);
    }
}