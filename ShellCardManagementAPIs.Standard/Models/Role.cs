// <copyright file="Role.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ShellCardManagementAPIs.Standard;
using ShellCardManagementAPIs.Standard.Utilities;

namespace ShellCardManagementAPIs.Standard.Models
{
    /// <summary>
    /// Role.
    /// </summary>
    public class Role
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Role"/> class.
        /// </summary>
        public Role()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Role"/> class.
        /// </summary>
        /// <param name="roleName">RoleName.</param>
        /// <param name="isCustomerAdmin">IsCustomerAdmin.</param>
        /// <param name="isCustomerUser">IsCustomerUser.</param>
        /// <param name="isShellAdmin">IsShellAdmin.</param>
        /// <param name="isServiceAccount">IsServiceAccount.</param>
        /// <param name="isUserAdmin">IsUserAdmin.</param>
        public Role(
            string roleName = null,
            bool? isCustomerAdmin = true,
            bool? isCustomerUser = false,
            bool? isShellAdmin = false,
            bool? isServiceAccount = false,
            bool? isUserAdmin = true)
        {
            this.RoleName = roleName;
            this.IsCustomerAdmin = isCustomerAdmin;
            this.IsCustomerUser = isCustomerUser;
            this.IsShellAdmin = isShellAdmin;
            this.IsServiceAccount = isServiceAccount;
            this.IsUserAdmin = isUserAdmin;
        }

        /// <summary>
        /// Role Name of the user
        /// </summary>
        [JsonProperty("RoleName", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleName { get; set; }

        /// <summary>
        /// Whether the role is an administrator.
        /// </summary>
        [JsonProperty("IsCustomerAdmin", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCustomerAdmin { get; set; }

        /// <summary>
        /// Whether the role is a customer user.
        /// </summary>
        [JsonProperty("IsCustomerUser", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCustomerUser { get; set; }

        /// <summary>
        /// True if the role is Shell user, else false.
        /// </summary>
        [JsonProperty("IsShellAdmin", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsShellAdmin { get; set; }

        /// <summary>
        /// True/False.
        /// True if the role is Service accounts, else false.
        /// </summary>
        [JsonProperty("IsServiceAccount", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsServiceAccount { get; set; }

        /// <summary>
        /// True/False.
        /// True, if the role allows user administration, else false.
        /// </summary>
        [JsonProperty("IsUserAdmin", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsUserAdmin { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Role : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Role other &&
                (this.RoleName == null && other.RoleName == null ||
                 this.RoleName?.Equals(other.RoleName) == true) &&
                (this.IsCustomerAdmin == null && other.IsCustomerAdmin == null ||
                 this.IsCustomerAdmin?.Equals(other.IsCustomerAdmin) == true) &&
                (this.IsCustomerUser == null && other.IsCustomerUser == null ||
                 this.IsCustomerUser?.Equals(other.IsCustomerUser) == true) &&
                (this.IsShellAdmin == null && other.IsShellAdmin == null ||
                 this.IsShellAdmin?.Equals(other.IsShellAdmin) == true) &&
                (this.IsServiceAccount == null && other.IsServiceAccount == null ||
                 this.IsServiceAccount?.Equals(other.IsServiceAccount) == true) &&
                (this.IsUserAdmin == null && other.IsUserAdmin == null ||
                 this.IsUserAdmin?.Equals(other.IsUserAdmin) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"RoleName = {this.RoleName ?? "null"}");
            toStringOutput.Add($"IsCustomerAdmin = {(this.IsCustomerAdmin == null ? "null" : this.IsCustomerAdmin.ToString())}");
            toStringOutput.Add($"IsCustomerUser = {(this.IsCustomerUser == null ? "null" : this.IsCustomerUser.ToString())}");
            toStringOutput.Add($"IsShellAdmin = {(this.IsShellAdmin == null ? "null" : this.IsShellAdmin.ToString())}");
            toStringOutput.Add($"IsServiceAccount = {(this.IsServiceAccount == null ? "null" : this.IsServiceAccount.ToString())}");
            toStringOutput.Add($"IsUserAdmin = {(this.IsUserAdmin == null ? "null" : this.IsUserAdmin.ToString())}");
        }
    }
}