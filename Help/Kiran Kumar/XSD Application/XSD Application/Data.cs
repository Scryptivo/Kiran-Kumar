﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.17929.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/Data.xsd")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/Data.xsd", IsNullable=false)]
public partial class Appointment {
    
    private int appointmentIdField;
    
    private System.DateTime createdDateField;
    
    private int createdByField;
    
    private int modifiedByField;
    
    private bool modifiedByFieldSpecified;
    
    private System.DateTime modifiedDateField;
    
    private bool modifiedDateFieldSpecified;
    
    private Response[] responseField;
    
    private Address addressField;
    
    private int typeField;
    
    private int goToField;
    
    /// <remarks/>
    public int AppointmentId {
        get {
            return this.appointmentIdField;
        }
        set {
            this.appointmentIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime CreatedDate {
        get {
            return this.createdDateField;
        }
        set {
            this.createdDateField = value;
        }
    }
    
    /// <remarks/>
    public int CreatedBy {
        get {
            return this.createdByField;
        }
        set {
            this.createdByField = value;
        }
    }
    
    /// <remarks/>
    public int ModifiedBy {
        get {
            return this.modifiedByField;
        }
        set {
            this.modifiedByField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ModifiedBySpecified {
        get {
            return this.modifiedByFieldSpecified;
        }
        set {
            this.modifiedByFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime ModifiedDate {
        get {
            return this.modifiedDateField;
        }
        set {
            this.modifiedDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ModifiedDateSpecified {
        get {
            return this.modifiedDateFieldSpecified;
        }
        set {
            this.modifiedDateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Response")]
    public Response[] Response {
        get {
            return this.responseField;
        }
        set {
            this.responseField = value;
        }
    }
    
    /// <remarks/>
    public Address Address {
        get {
            return this.addressField;
        }
        set {
            this.addressField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int Type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int GoTo {
        get {
            return this.goToField;
        }
        set {
            this.goToField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/Data.xsd")]
public partial class Response {
    
    private int responseIdField;
    
    private int appointmentIdField;
    
    private Address addressField;
    
    private System.DateTime createdDateField;
    
    private int createdByField;
    
    private int modifiedByField;
    
    private bool modifiedByFieldSpecified;
    
    private System.DateTime modifiedDateField;
    
    private bool modifiedDateFieldSpecified;
    
    /// <remarks/>
    public int ResponseId {
        get {
            return this.responseIdField;
        }
        set {
            this.responseIdField = value;
        }
    }
    
    /// <remarks/>
    public int AppointmentId {
        get {
            return this.appointmentIdField;
        }
        set {
            this.appointmentIdField = value;
        }
    }
    
    /// <remarks/>
    public Address Address {
        get {
            return this.addressField;
        }
        set {
            this.addressField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime CreatedDate {
        get {
            return this.createdDateField;
        }
        set {
            this.createdDateField = value;
        }
    }
    
    /// <remarks/>
    public int CreatedBy {
        get {
            return this.createdByField;
        }
        set {
            this.createdByField = value;
        }
    }
    
    /// <remarks/>
    public int ModifiedBy {
        get {
            return this.modifiedByField;
        }
        set {
            this.modifiedByField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ModifiedBySpecified {
        get {
            return this.modifiedByFieldSpecified;
        }
        set {
            this.modifiedByFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime ModifiedDate {
        get {
            return this.modifiedDateField;
        }
        set {
            this.modifiedDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ModifiedDateSpecified {
        get {
            return this.modifiedDateFieldSpecified;
        }
        set {
            this.modifiedDateFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/Data.xsd")]
public partial class Address {
    
    private string itemField;
    
    private ItemChoiceType itemElementNameField;
    
    private string postField;
    
    private string districtField;
    
    private string stateField;
    
    private string countryField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("City", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Village", typeof(string))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType ItemElementName {
        get {
            return this.itemElementNameField;
        }
        set {
            this.itemElementNameField = value;
        }
    }
    
    /// <remarks/>
    public string Post {
        get {
            return this.postField;
        }
        set {
            this.postField = value;
        }
    }
    
    /// <remarks/>
    public string District {
        get {
            return this.districtField;
        }
        set {
            this.districtField = value;
        }
    }
    
    /// <remarks/>
    public string State {
        get {
            return this.stateField;
        }
        set {
            this.stateField = value;
        }
    }
    
    /// <remarks/>
    public string Country {
        get {
            return this.countryField;
        }
        set {
            this.countryField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/Data.xsd", IncludeInSchema=false)]
public enum ItemChoiceType {
    
    /// <remarks/>
    City,
    
    /// <remarks/>
    Village,
}