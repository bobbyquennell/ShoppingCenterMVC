﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34209
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShoppingCenter.UserManage {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CommonResult", Namespace="http://schemas.datacontract.org/2004/07/ShoppingCenterWCF")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ShoppingCenter.UserManage.SignInResult))]
    public partial class CommonResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SuccessField;
        
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
        public string ErrorMessage {
            get {
                return this.ErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMessageField, value) != true)) {
                    this.ErrorMessageField = value;
                    this.RaisePropertyChanged("ErrorMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Success {
            get {
                return this.SuccessField;
            }
            set {
                if ((this.SuccessField.Equals(value) != true)) {
                    this.SuccessField = value;
                    this.RaisePropertyChanged("Success");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SignInResult", Namespace="http://schemas.datacontract.org/2004/07/ShoppingCenterWCF")]
    [System.SerializableAttribute()]
    public partial class SignInResult : ShoppingCenter.UserManage.CommonResult {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ShoppingCenter.UserManage.User UserField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ShoppingCenter.UserManage.User User {
            get {
                return this.UserField;
            }
            set {
                if ((object.ReferenceEquals(this.UserField, value) != true)) {
                    this.UserField = value;
                    this.RaisePropertyChanged("User");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/ShoppingCenterBOL")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid ConfirmationCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsConfirmedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ShoppingCenter.UserManage.UserInfo UserInfoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserTypeField;
        
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
        public System.Guid ConfirmationCode {
            get {
                return this.ConfirmationCodeField;
            }
            set {
                if ((this.ConfirmationCodeField.Equals(value) != true)) {
                    this.ConfirmationCodeField = value;
                    this.RaisePropertyChanged("ConfirmationCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsConfirmed {
            get {
                return this.IsConfirmedField;
            }
            set {
                if ((this.IsConfirmedField.Equals(value) != true)) {
                    this.IsConfirmedField = value;
                    this.RaisePropertyChanged("IsConfirmed");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ShoppingCenter.UserManage.UserInfo UserInfo {
            get {
                return this.UserInfoField;
            }
            set {
                if ((object.ReferenceEquals(this.UserInfoField, value) != true)) {
                    this.UserInfoField = value;
                    this.RaisePropertyChanged("UserInfo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserType {
            get {
                return this.UserTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.UserTypeField, value) != true)) {
                    this.UserTypeField = value;
                    this.RaisePropertyChanged("UserType");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserInfo", Namespace="http://schemas.datacontract.org/2004/07/ShoppingCenterBOL")]
    [System.SerializableAttribute()]
    public partial class UserInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime SignInDateTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ShoppingCenter.UserManage.User UserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
        public System.DateTime SignInDateTime {
            get {
                return this.SignInDateTimeField;
            }
            set {
                if ((this.SignInDateTimeField.Equals(value) != true)) {
                    this.SignInDateTimeField = value;
                    this.RaisePropertyChanged("SignInDateTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ShoppingCenter.UserManage.User User {
            get {
                return this.UserField;
            }
            set {
                if ((object.ReferenceEquals(this.UserField, value) != true)) {
                    this.UserField = value;
                    this.RaisePropertyChanged("User");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserManage.IUserManageService")]
    public interface IUserManageService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManageService/SignUp", ReplyAction="http://tempuri.org/IUserManageService/SignUpResponse")]
        ShoppingCenter.UserManage.CommonResult SignUp(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManageService/SignUp", ReplyAction="http://tempuri.org/IUserManageService/SignUpResponse")]
        System.Threading.Tasks.Task<ShoppingCenter.UserManage.CommonResult> SignUpAsync(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManageService/ActiveAccount", ReplyAction="http://tempuri.org/IUserManageService/ActiveAccountResponse")]
        ShoppingCenter.UserManage.CommonResult ActiveAccount(string email, string confirmationCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManageService/ActiveAccount", ReplyAction="http://tempuri.org/IUserManageService/ActiveAccountResponse")]
        System.Threading.Tasks.Task<ShoppingCenter.UserManage.CommonResult> ActiveAccountAsync(string email, string confirmationCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManageService/ChangePassword", ReplyAction="http://tempuri.org/IUserManageService/ChangePasswordResponse")]
        ShoppingCenter.UserManage.CommonResult ChangePassword(int userId, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManageService/ChangePassword", ReplyAction="http://tempuri.org/IUserManageService/ChangePasswordResponse")]
        System.Threading.Tasks.Task<ShoppingCenter.UserManage.CommonResult> ChangePasswordAsync(int userId, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManageService/ChangeUserName", ReplyAction="http://tempuri.org/IUserManageService/ChangeUserNameResponse")]
        ShoppingCenter.UserManage.CommonResult ChangeUserName(int userId, string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManageService/ChangeUserName", ReplyAction="http://tempuri.org/IUserManageService/ChangeUserNameResponse")]
        System.Threading.Tasks.Task<ShoppingCenter.UserManage.CommonResult> ChangeUserNameAsync(int userId, string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManageService/ChangeEmail", ReplyAction="http://tempuri.org/IUserManageService/ChangeEmailResponse")]
        ShoppingCenter.UserManage.CommonResult ChangeEmail(int userId, string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManageService/ChangeEmail", ReplyAction="http://tempuri.org/IUserManageService/ChangeEmailResponse")]
        System.Threading.Tasks.Task<ShoppingCenter.UserManage.CommonResult> ChangeEmailAsync(int userId, string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManageService/SignIn", ReplyAction="http://tempuri.org/IUserManageService/SignInResponse")]
        ShoppingCenter.UserManage.SignInResult SignIn(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManageService/SignIn", ReplyAction="http://tempuri.org/IUserManageService/SignInResponse")]
        System.Threading.Tasks.Task<ShoppingCenter.UserManage.SignInResult> SignInAsync(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManageService/ReSendConfirmationEmail", ReplyAction="http://tempuri.org/IUserManageService/ReSendConfirmationEmailResponse")]
        ShoppingCenter.UserManage.CommonResult ReSendConfirmationEmail(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManageService/ReSendConfirmationEmail", ReplyAction="http://tempuri.org/IUserManageService/ReSendConfirmationEmailResponse")]
        System.Threading.Tasks.Task<ShoppingCenter.UserManage.CommonResult> ReSendConfirmationEmailAsync(int userId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserManageServiceChannel : ShoppingCenter.UserManage.IUserManageService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserManageServiceClient : System.ServiceModel.ClientBase<ShoppingCenter.UserManage.IUserManageService>, ShoppingCenter.UserManage.IUserManageService {
        
        public UserManageServiceClient() {
        }
        
        public UserManageServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserManageServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserManageServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserManageServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ShoppingCenter.UserManage.CommonResult SignUp(string email, string password) {
            return base.Channel.SignUp(email, password);
        }
        
        public System.Threading.Tasks.Task<ShoppingCenter.UserManage.CommonResult> SignUpAsync(string email, string password) {
            return base.Channel.SignUpAsync(email, password);
        }
        
        public ShoppingCenter.UserManage.CommonResult ActiveAccount(string email, string confirmationCode) {
            return base.Channel.ActiveAccount(email, confirmationCode);
        }
        
        public System.Threading.Tasks.Task<ShoppingCenter.UserManage.CommonResult> ActiveAccountAsync(string email, string confirmationCode) {
            return base.Channel.ActiveAccountAsync(email, confirmationCode);
        }
        
        public ShoppingCenter.UserManage.CommonResult ChangePassword(int userId, string password) {
            return base.Channel.ChangePassword(userId, password);
        }
        
        public System.Threading.Tasks.Task<ShoppingCenter.UserManage.CommonResult> ChangePasswordAsync(int userId, string password) {
            return base.Channel.ChangePasswordAsync(userId, password);
        }
        
        public ShoppingCenter.UserManage.CommonResult ChangeUserName(int userId, string userName) {
            return base.Channel.ChangeUserName(userId, userName);
        }
        
        public System.Threading.Tasks.Task<ShoppingCenter.UserManage.CommonResult> ChangeUserNameAsync(int userId, string userName) {
            return base.Channel.ChangeUserNameAsync(userId, userName);
        }
        
        public ShoppingCenter.UserManage.CommonResult ChangeEmail(int userId, string email) {
            return base.Channel.ChangeEmail(userId, email);
        }
        
        public System.Threading.Tasks.Task<ShoppingCenter.UserManage.CommonResult> ChangeEmailAsync(int userId, string email) {
            return base.Channel.ChangeEmailAsync(userId, email);
        }
        
        public ShoppingCenter.UserManage.SignInResult SignIn(string email, string password) {
            return base.Channel.SignIn(email, password);
        }
        
        public System.Threading.Tasks.Task<ShoppingCenter.UserManage.SignInResult> SignInAsync(string email, string password) {
            return base.Channel.SignInAsync(email, password);
        }
        
        public ShoppingCenter.UserManage.CommonResult ReSendConfirmationEmail(int userId) {
            return base.Channel.ReSendConfirmationEmail(userId);
        }
        
        public System.Threading.Tasks.Task<ShoppingCenter.UserManage.CommonResult> ReSendConfirmationEmailAsync(int userId) {
            return base.Channel.ReSendConfirmationEmailAsync(userId);
        }
    }
}
