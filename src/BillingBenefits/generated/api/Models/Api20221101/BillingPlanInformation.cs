// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Extensions;

    /// <summary>Information describing the type of billing plan for this savings plan.</summary>
    public partial class BillingPlanInformation :
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IBillingPlanInformation,
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IBillingPlanInformationInternal
    {

        /// <summary>Internal Acessors for PricingCurrencyTotal</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IPrice Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IBillingPlanInformationInternal.PricingCurrencyTotal { get => (this._pricingCurrencyTotal = this._pricingCurrencyTotal ?? new Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.Price()); set { {_pricingCurrencyTotal = value;} } }

        /// <summary>Backing field for <see cref="NextPaymentDueDate" /> property.</summary>
        private global::System.DateTime? _nextPaymentDueDate;

        /// <summary>
        /// For recurring billing plans, indicates the date when next payment will be processed. Null when total is paid off.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        public global::System.DateTime? NextPaymentDueDate { get => this._nextPaymentDueDate; set => this._nextPaymentDueDate = value; }

        /// <summary>Backing field for <see cref="PricingCurrencyTotal" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IPrice _pricingCurrencyTotal;

        /// <summary>Amount of money to be paid for the Order. Tax is not included.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IPrice PricingCurrencyTotal { get => (this._pricingCurrencyTotal = this._pricingCurrencyTotal ?? new Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.Price()); set => this._pricingCurrencyTotal = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public double? PricingCurrencyTotalAmount { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IPriceInternal)PricingCurrencyTotal).Amount; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IPriceInternal)PricingCurrencyTotal).Amount = value ?? default(double); }

        /// <summary>
        /// The ISO 4217 3-letter currency code for the currency used by this purchase record.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public string PricingCurrencyTotalCurrencyCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IPriceInternal)PricingCurrencyTotal).CurrencyCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IPriceInternal)PricingCurrencyTotal).CurrencyCode = value ?? null; }

        /// <summary>Backing field for <see cref="StartDate" /> property.</summary>
        private global::System.DateTime? _startDate;

        /// <summary>Date when the billing plan has started.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        public global::System.DateTime? StartDate { get => this._startDate; set => this._startDate = value; }

        /// <summary>Backing field for <see cref="Transaction" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IPaymentDetail[] _transaction;

        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IPaymentDetail[] Transaction { get => this._transaction; set => this._transaction = value; }

        /// <summary>Creates an new <see cref="BillingPlanInformation" /> instance.</summary>
        public BillingPlanInformation()
        {

        }
    }
    /// Information describing the type of billing plan for this savings plan.
    public partial interface IBillingPlanInformation :
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.IJsonSerializable
    {
        /// <summary>
        /// For recurring billing plans, indicates the date when next payment will be processed. Null when total is paid off.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"For recurring billing plans, indicates the date when next payment will be processed. Null when total is paid off.",
        SerializedName = @"nextPaymentDueDate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? NextPaymentDueDate { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"amount",
        PossibleTypes = new [] { typeof(double) })]
        double? PricingCurrencyTotalAmount { get; set; }
        /// <summary>
        /// The ISO 4217 3-letter currency code for the currency used by this purchase record.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ISO 4217 3-letter currency code for the currency used by this purchase record.",
        SerializedName = @"currencyCode",
        PossibleTypes = new [] { typeof(string) })]
        string PricingCurrencyTotalCurrencyCode { get; set; }
        /// <summary>Date when the billing plan has started.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Date when the billing plan has started.",
        SerializedName = @"startDate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StartDate { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"transactions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IPaymentDetail) })]
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IPaymentDetail[] Transaction { get; set; }

    }
    /// Information describing the type of billing plan for this savings plan.
    internal partial interface IBillingPlanInformationInternal

    {
        /// <summary>
        /// For recurring billing plans, indicates the date when next payment will be processed. Null when total is paid off.
        /// </summary>
        global::System.DateTime? NextPaymentDueDate { get; set; }
        /// <summary>Amount of money to be paid for the Order. Tax is not included.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IPrice PricingCurrencyTotal { get; set; }

        double? PricingCurrencyTotalAmount { get; set; }
        /// <summary>
        /// The ISO 4217 3-letter currency code for the currency used by this purchase record.
        /// </summary>
        string PricingCurrencyTotalCurrencyCode { get; set; }
        /// <summary>Date when the billing plan has started.</summary>
        global::System.DateTime? StartDate { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IPaymentDetail[] Transaction { get; set; }

    }
}