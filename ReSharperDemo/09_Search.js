function UpdateValidations() {
    var name = "Lisa";

    if (name = "Lisa") {
        alert('Simpson');
    }

    var txt = $find("<%= txtVariablePrefix.ClientID %>");
    if (txt) {
        txt.set_maxLength(maxlength);
        txt.set_value("");
    }
}

function Disable() {
    var objState = $find("<%= txtVariablePrefix.ClientID %>");
    objState.disable();
}

function Enable() {
    var objState = $find("<%= txtVariablePrefix.ClientID %>");
    objState.enable();
}

function UpdateNarratives() {

    $("#<%= prefix.ClientID %>").show();
    $("#<%= @fixed.ClientID %>").show();
    $("#<%= free.ClientID %>").show();
    $("#<%= autogen.ClientID %>").show();
    $("#<%= template.ClientID %>").show();
}

function showMessage() {
    alert('Testing');
}