﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sprawdź_NIP.BIR1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ParametryWyszukiwania", Namespace="http://CIS/BIR/PUBL/2014/07/DataContract")]
    [System.SerializableAttribute()]
    public partial class ParametryWyszukiwania : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KrsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KrsyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NipField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NipyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RegonField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Regony14znField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Regony9znField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Krs {
            get {
                return this.KrsField;
            }
            set {
                if ((object.ReferenceEquals(this.KrsField, value) != true)) {
                    this.KrsField = value;
                    this.RaisePropertyChanged("Krs");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Krsy {
            get {
                return this.KrsyField;
            }
            set {
                if ((object.ReferenceEquals(this.KrsyField, value) != true)) {
                    this.KrsyField = value;
                    this.RaisePropertyChanged("Krsy");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nip {
            get {
                return this.NipField;
            }
            set {
                if ((object.ReferenceEquals(this.NipField, value) != true)) {
                    this.NipField = value;
                    this.RaisePropertyChanged("Nip");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nipy {
            get {
                return this.NipyField;
            }
            set {
                if ((object.ReferenceEquals(this.NipyField, value) != true)) {
                    this.NipyField = value;
                    this.RaisePropertyChanged("Nipy");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Regon {
            get {
                return this.RegonField;
            }
            set {
                if ((object.ReferenceEquals(this.RegonField, value) != true)) {
                    this.RegonField = value;
                    this.RaisePropertyChanged("Regon");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Regony14zn {
            get {
                return this.Regony14znField;
            }
            set {
                if ((object.ReferenceEquals(this.Regony14znField, value) != true)) {
                    this.Regony14znField = value;
                    this.RaisePropertyChanged("Regony14zn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Regony9zn {
            get {
                return this.Regony9znField;
            }
            set {
                if ((object.ReferenceEquals(this.Regony9znField, value) != true)) {
                    this.Regony9znField = value;
                    this.RaisePropertyChanged("Regony9zn");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", ConfigurationName="BIR1.IUslugaBIRzewnPubl")]
    public interface IUslugaBIRzewnPubl {
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ przestrzeń nazw otoki (http://CIS/BIR/2014/07) komunikatu PobierzCaptchaRequest nie pasuje do domyślnej wartości (http://CIS/BIR/PUBL/2014/07).
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/2014/07/IUslugaBIR/PobierzCaptcha", ReplyAction="http://CIS/BIR/2014/07/IUslugaBIR/PobierzCaptchaResponse")]
        Sprawdź_NIP.BIR1.PobierzCaptchaResponse PobierzCaptcha(Sprawdź_NIP.BIR1.PobierzCaptchaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/2014/07/IUslugaBIR/PobierzCaptcha", ReplyAction="http://CIS/BIR/2014/07/IUslugaBIR/PobierzCaptchaResponse")]
        System.Threading.Tasks.Task<Sprawdź_NIP.BIR1.PobierzCaptchaResponse> PobierzCaptchaAsync(Sprawdź_NIP.BIR1.PobierzCaptchaRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ przestrzeń nazw otoki (http://CIS/BIR/2014/07) komunikatu SprawdzCaptchaRequest nie pasuje do domyślnej wartości (http://CIS/BIR/PUBL/2014/07).
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/2014/07/IUslugaBIR/SprawdzCaptcha", ReplyAction="http://CIS/BIR/2014/07/IUslugaBIR/SprawdzCaptchaResponse")]
        Sprawdź_NIP.BIR1.SprawdzCaptchaResponse SprawdzCaptcha(Sprawdź_NIP.BIR1.SprawdzCaptchaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/2014/07/IUslugaBIR/SprawdzCaptcha", ReplyAction="http://CIS/BIR/2014/07/IUslugaBIR/SprawdzCaptchaResponse")]
        System.Threading.Tasks.Task<Sprawdź_NIP.BIR1.SprawdzCaptchaResponse> SprawdzCaptchaAsync(Sprawdź_NIP.BIR1.SprawdzCaptchaRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ przestrzeń nazw otoki (http://CIS/BIR/2014/07) komunikatu SetValueRequest nie pasuje do domyślnej wartości (http://CIS/BIR/PUBL/2014/07).
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/2014/07/IUslugaBIR/SetValue", ReplyAction="http://CIS/BIR/2014/07/IUslugaBIR/SetValueResponse")]
        Sprawdź_NIP.BIR1.SetValueResponse SetValue(Sprawdź_NIP.BIR1.SetValueRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/2014/07/IUslugaBIR/SetValue", ReplyAction="http://CIS/BIR/2014/07/IUslugaBIR/SetValueResponse")]
        System.Threading.Tasks.Task<Sprawdź_NIP.BIR1.SetValueResponse> SetValueAsync(Sprawdź_NIP.BIR1.SetValueRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ przestrzeń nazw otoki (http://CIS/BIR/2014/07) komunikatu GetValueRequest nie pasuje do domyślnej wartości (http://CIS/BIR/PUBL/2014/07).
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/2014/07/IUslugaBIR/GetValue", ReplyAction="http://CIS/BIR/2014/07/IUslugaBIR/GetValueResponse")]
        Sprawdź_NIP.BIR1.GetValueResponse GetValue(Sprawdź_NIP.BIR1.GetValueRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/2014/07/IUslugaBIR/GetValue", ReplyAction="http://CIS/BIR/2014/07/IUslugaBIR/GetValueResponse")]
        System.Threading.Tasks.Task<Sprawdź_NIP.BIR1.GetValueResponse> GetValueAsync(Sprawdź_NIP.BIR1.GetValueRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/Zaloguj", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/ZalogujResponse")]
        string Zaloguj(string pKluczUzytkownika);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/Zaloguj", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/ZalogujResponse")]
        System.Threading.Tasks.Task<string> ZalogujAsync(string pKluczUzytkownika);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/Wyloguj", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/WylogujResponse")]
        bool Wyloguj(string pIdentyfikatorSesji);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/Wyloguj", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/WylogujResponse")]
        System.Threading.Tasks.Task<bool> WylogujAsync(string pIdentyfikatorSesji);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DaneSzukaj", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DaneSzukajResponse")]
        string DaneSzukaj(Sprawdź_NIP.BIR1.ParametryWyszukiwania pParametryWyszukiwania);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DaneSzukaj", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DaneSzukajResponse")]
        System.Threading.Tasks.Task<string> DaneSzukajAsync(Sprawdź_NIP.BIR1.ParametryWyszukiwania pParametryWyszukiwania);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzPelnyRaport", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzPelnyRaportResponse")]
        string DanePobierzPelnyRaport(string pRegon, string pNazwaRaportu);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzPelnyRaport", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzPelnyRaportResponse")]
        System.Threading.Tasks.Task<string> DanePobierzPelnyRaportAsync(string pRegon, string pNazwaRaportu);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DaneKomunikat", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DaneKomunikatResponse")]
        string DaneKomunikat();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DaneKomunikat", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DaneKomunikatResponse")]
        System.Threading.Tasks.Task<string> DaneKomunikatAsync();
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="PobierzCaptcha", WrapperNamespace="http://CIS/BIR/2014/07", IsWrapped=true)]
    public partial class PobierzCaptchaRequest {
        
        public PobierzCaptchaRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="PobierzCaptchaResponse", WrapperNamespace="http://CIS/BIR/2014/07", IsWrapped=true)]
    public partial class PobierzCaptchaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/2014/07", Order=0)]
        public string PobierzCaptchaResult;
        
        public PobierzCaptchaResponse() {
        }
        
        public PobierzCaptchaResponse(string PobierzCaptchaResult) {
            this.PobierzCaptchaResult = PobierzCaptchaResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SprawdzCaptcha", WrapperNamespace="http://CIS/BIR/2014/07", IsWrapped=true)]
    public partial class SprawdzCaptchaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/2014/07", Order=0)]
        public string pCaptcha;
        
        public SprawdzCaptchaRequest() {
        }
        
        public SprawdzCaptchaRequest(string pCaptcha) {
            this.pCaptcha = pCaptcha;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SprawdzCaptchaResponse", WrapperNamespace="http://CIS/BIR/2014/07", IsWrapped=true)]
    public partial class SprawdzCaptchaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/2014/07", Order=0)]
        public bool SprawdzCaptchaResult;
        
        public SprawdzCaptchaResponse() {
        }
        
        public SprawdzCaptchaResponse(bool SprawdzCaptchaResult) {
            this.SprawdzCaptchaResult = SprawdzCaptchaResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetValue", WrapperNamespace="http://CIS/BIR/2014/07", IsWrapped=true)]
    public partial class SetValueRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/2014/07", Order=0)]
        public string pNazwaParametru;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/2014/07", Order=1)]
        public string pWartoscParametru;
        
        public SetValueRequest() {
        }
        
        public SetValueRequest(string pNazwaParametru, string pWartoscParametru) {
            this.pNazwaParametru = pNazwaParametru;
            this.pWartoscParametru = pWartoscParametru;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetValueResponse", WrapperNamespace="http://CIS/BIR/2014/07", IsWrapped=true)]
    public partial class SetValueResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/2014/07", Order=0)]
        public string SetValueResult;
        
        public SetValueResponse() {
        }
        
        public SetValueResponse(string SetValueResult) {
            this.SetValueResult = SetValueResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetValue", WrapperNamespace="http://CIS/BIR/2014/07", IsWrapped=true)]
    public partial class GetValueRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/2014/07", Order=0)]
        public string pNazwaParametru;
        
        public GetValueRequest() {
        }
        
        public GetValueRequest(string pNazwaParametru) {
            this.pNazwaParametru = pNazwaParametru;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetValueResponse", WrapperNamespace="http://CIS/BIR/2014/07", IsWrapped=true)]
    public partial class GetValueResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/2014/07", Order=0)]
        public string GetValueResult;
        
        public GetValueResponse() {
        }
        
        public GetValueResponse(string GetValueResult) {
            this.GetValueResult = GetValueResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUslugaBIRzewnPublChannel : Sprawdź_NIP.BIR1.IUslugaBIRzewnPubl, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UslugaBIRzewnPublClient : System.ServiceModel.ClientBase<Sprawdź_NIP.BIR1.IUslugaBIRzewnPubl>, Sprawdź_NIP.BIR1.IUslugaBIRzewnPubl {
        
        public UslugaBIRzewnPublClient() {
        }
        
        public UslugaBIRzewnPublClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UslugaBIRzewnPublClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UslugaBIRzewnPublClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UslugaBIRzewnPublClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Sprawdź_NIP.BIR1.PobierzCaptchaResponse Sprawdź_NIP.BIR1.IUslugaBIRzewnPubl.PobierzCaptcha(Sprawdź_NIP.BIR1.PobierzCaptchaRequest request) {
            return base.Channel.PobierzCaptcha(request);
        }
        
        public string PobierzCaptcha() {
            Sprawdź_NIP.BIR1.PobierzCaptchaRequest inValue = new Sprawdź_NIP.BIR1.PobierzCaptchaRequest();
            Sprawdź_NIP.BIR1.PobierzCaptchaResponse retVal = ((Sprawdź_NIP.BIR1.IUslugaBIRzewnPubl)(this)).PobierzCaptcha(inValue);
            return retVal.PobierzCaptchaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Sprawdź_NIP.BIR1.PobierzCaptchaResponse> Sprawdź_NIP.BIR1.IUslugaBIRzewnPubl.PobierzCaptchaAsync(Sprawdź_NIP.BIR1.PobierzCaptchaRequest request) {
            return base.Channel.PobierzCaptchaAsync(request);
        }
        
        public System.Threading.Tasks.Task<Sprawdź_NIP.BIR1.PobierzCaptchaResponse> PobierzCaptchaAsync() {
            Sprawdź_NIP.BIR1.PobierzCaptchaRequest inValue = new Sprawdź_NIP.BIR1.PobierzCaptchaRequest();
            return ((Sprawdź_NIP.BIR1.IUslugaBIRzewnPubl)(this)).PobierzCaptchaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Sprawdź_NIP.BIR1.SprawdzCaptchaResponse Sprawdź_NIP.BIR1.IUslugaBIRzewnPubl.SprawdzCaptcha(Sprawdź_NIP.BIR1.SprawdzCaptchaRequest request) {
            return base.Channel.SprawdzCaptcha(request);
        }
        
        public bool SprawdzCaptcha(string pCaptcha) {
            Sprawdź_NIP.BIR1.SprawdzCaptchaRequest inValue = new Sprawdź_NIP.BIR1.SprawdzCaptchaRequest();
            inValue.pCaptcha = pCaptcha;
            Sprawdź_NIP.BIR1.SprawdzCaptchaResponse retVal = ((Sprawdź_NIP.BIR1.IUslugaBIRzewnPubl)(this)).SprawdzCaptcha(inValue);
            return retVal.SprawdzCaptchaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Sprawdź_NIP.BIR1.SprawdzCaptchaResponse> Sprawdź_NIP.BIR1.IUslugaBIRzewnPubl.SprawdzCaptchaAsync(Sprawdź_NIP.BIR1.SprawdzCaptchaRequest request) {
            return base.Channel.SprawdzCaptchaAsync(request);
        }
        
        public System.Threading.Tasks.Task<Sprawdź_NIP.BIR1.SprawdzCaptchaResponse> SprawdzCaptchaAsync(string pCaptcha) {
            Sprawdź_NIP.BIR1.SprawdzCaptchaRequest inValue = new Sprawdź_NIP.BIR1.SprawdzCaptchaRequest();
            inValue.pCaptcha = pCaptcha;
            return ((Sprawdź_NIP.BIR1.IUslugaBIRzewnPubl)(this)).SprawdzCaptchaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Sprawdź_NIP.BIR1.SetValueResponse Sprawdź_NIP.BIR1.IUslugaBIRzewnPubl.SetValue(Sprawdź_NIP.BIR1.SetValueRequest request) {
            return base.Channel.SetValue(request);
        }
        
        public string SetValue(string pNazwaParametru, string pWartoscParametru) {
            Sprawdź_NIP.BIR1.SetValueRequest inValue = new Sprawdź_NIP.BIR1.SetValueRequest();
            inValue.pNazwaParametru = pNazwaParametru;
            inValue.pWartoscParametru = pWartoscParametru;
            Sprawdź_NIP.BIR1.SetValueResponse retVal = ((Sprawdź_NIP.BIR1.IUslugaBIRzewnPubl)(this)).SetValue(inValue);
            return retVal.SetValueResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Sprawdź_NIP.BIR1.SetValueResponse> Sprawdź_NIP.BIR1.IUslugaBIRzewnPubl.SetValueAsync(Sprawdź_NIP.BIR1.SetValueRequest request) {
            return base.Channel.SetValueAsync(request);
        }
        
        public System.Threading.Tasks.Task<Sprawdź_NIP.BIR1.SetValueResponse> SetValueAsync(string pNazwaParametru, string pWartoscParametru) {
            Sprawdź_NIP.BIR1.SetValueRequest inValue = new Sprawdź_NIP.BIR1.SetValueRequest();
            inValue.pNazwaParametru = pNazwaParametru;
            inValue.pWartoscParametru = pWartoscParametru;
            return ((Sprawdź_NIP.BIR1.IUslugaBIRzewnPubl)(this)).SetValueAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Sprawdź_NIP.BIR1.GetValueResponse Sprawdź_NIP.BIR1.IUslugaBIRzewnPubl.GetValue(Sprawdź_NIP.BIR1.GetValueRequest request) {
            return base.Channel.GetValue(request);
        }
        
        public string GetValue(string pNazwaParametru) {
            Sprawdź_NIP.BIR1.GetValueRequest inValue = new Sprawdź_NIP.BIR1.GetValueRequest();
            inValue.pNazwaParametru = pNazwaParametru;
            Sprawdź_NIP.BIR1.GetValueResponse retVal = ((Sprawdź_NIP.BIR1.IUslugaBIRzewnPubl)(this)).GetValue(inValue);
            return retVal.GetValueResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Sprawdź_NIP.BIR1.GetValueResponse> Sprawdź_NIP.BIR1.IUslugaBIRzewnPubl.GetValueAsync(Sprawdź_NIP.BIR1.GetValueRequest request) {
            return base.Channel.GetValueAsync(request);
        }
        
        public System.Threading.Tasks.Task<Sprawdź_NIP.BIR1.GetValueResponse> GetValueAsync(string pNazwaParametru) {
            Sprawdź_NIP.BIR1.GetValueRequest inValue = new Sprawdź_NIP.BIR1.GetValueRequest();
            inValue.pNazwaParametru = pNazwaParametru;
            return ((Sprawdź_NIP.BIR1.IUslugaBIRzewnPubl)(this)).GetValueAsync(inValue);
        }
        
        public string Zaloguj(string pKluczUzytkownika) {
            return base.Channel.Zaloguj(pKluczUzytkownika);
        }
        
        public System.Threading.Tasks.Task<string> ZalogujAsync(string pKluczUzytkownika) {
            return base.Channel.ZalogujAsync(pKluczUzytkownika);
        }
        
        public bool Wyloguj(string pIdentyfikatorSesji) {
            return base.Channel.Wyloguj(pIdentyfikatorSesji);
        }
        
        public System.Threading.Tasks.Task<bool> WylogujAsync(string pIdentyfikatorSesji) {
            return base.Channel.WylogujAsync(pIdentyfikatorSesji);
        }
        
        public string DaneSzukaj(Sprawdź_NIP.BIR1.ParametryWyszukiwania pParametryWyszukiwania) {
            return base.Channel.DaneSzukaj(pParametryWyszukiwania);
        }
        
        public System.Threading.Tasks.Task<string> DaneSzukajAsync(Sprawdź_NIP.BIR1.ParametryWyszukiwania pParametryWyszukiwania) {
            return base.Channel.DaneSzukajAsync(pParametryWyszukiwania);
        }
        
        public string DanePobierzPelnyRaport(string pRegon, string pNazwaRaportu) {
            return base.Channel.DanePobierzPelnyRaport(pRegon, pNazwaRaportu);
        }
        
        public System.Threading.Tasks.Task<string> DanePobierzPelnyRaportAsync(string pRegon, string pNazwaRaportu) {
            return base.Channel.DanePobierzPelnyRaportAsync(pRegon, pNazwaRaportu);
        }
        
        public string DaneKomunikat() {
            return base.Channel.DaneKomunikat();
        }
        
        public System.Threading.Tasks.Task<string> DaneKomunikatAsync() {
            return base.Channel.DaneKomunikatAsync();
        }
    }
}
