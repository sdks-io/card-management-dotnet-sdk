// <copyright file="UsageRestriction.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace ShellCardManagementAPIs.Standard.Models
{
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

    /// <summary>
    /// UsageRestriction.
    /// </summary>
    public class UsageRestriction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsageRestriction"/> class.
        /// </summary>
        public UsageRestriction()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageRestriction"/> class.
        /// </summary>
        /// <param name="level">Level.</param>
        /// <param name="dailySpend">DailySpend.</param>
        /// <param name="dailySpendAccumulated">DailySpendAccumulated.</param>
        /// <param name="dailySpendBalance">DailySpendBalance.</param>
        /// <param name="dailySpendOverride">DailySpendOverride.</param>
        /// <param name="dailySpendThreshold">DailySpendThreshold.</param>
        /// <param name="weeklySpend">WeeklySpend.</param>
        /// <param name="weeklySpendAccumulated">WeeklySpendAccumulated.</param>
        /// <param name="weeklySpendBalance">WeeklySpendBalance.</param>
        /// <param name="weeklySpendOverride">WeeklySpendOverride.</param>
        /// <param name="weeklySpendThreshold">WeeklySpendThreshold.</param>
        /// <param name="monthlySpend">MonthlySpend.</param>
        /// <param name="monthlySpendAccumulated">MonthlySpendAccumulated.</param>
        /// <param name="monthlySpendBalance">MonthlySpendBalance.</param>
        /// <param name="monthlySpendOverride">MonthlySpendOverride.</param>
        /// <param name="perTransactionSpend">PerTransactionSpend.</param>
        /// <param name="perTransactionSpendOverride">PerTransactionSpendOverride.</param>
        /// <param name="annualSpend">AnnualSpend.</param>
        /// <param name="annualSpendAccumulated">AnnualSpendAccumulated.</param>
        /// <param name="annualSpendBalance">AnnualSpendBalance.</param>
        /// <param name="annualSpendOverride">AnnualSpendOverride.</param>
        /// <param name="annualSpendThreshold">AnnualSpendThreshold.</param>
        /// <param name="lifeTimeSpend">LifeTimeSpend.</param>
        /// <param name="lifeTimeSpendAccumulated">LifeTimeSpendAccumulated.</param>
        /// <param name="lifeTimeSpendBalance">LifeTimeSpendBalance.</param>
        /// <param name="lifeTimeSpendOverride">LifeTimeSpendOverride.</param>
        /// <param name="lifeTimeSpendThreshold">LifeTimeSpendThreshold.</param>
        /// <param name="dailyVolume">DailyVolume.</param>
        /// <param name="dailyVolumeAccumulated">DailyVolumeAccumulated.</param>
        /// <param name="dailyVolumeBalance">DailyVolumeBalance.</param>
        /// <param name="dailyVolumeOverride">DailyVolumeOverride.</param>
        /// <param name="dailyVolumeThreshold">DailyVolumeThreshold.</param>
        /// <param name="weeklyVolume">WeeklyVolume.</param>
        /// <param name="weeklyVolumeAccumulated">WeeklyVolumeAccumulated.</param>
        /// <param name="weeklyVolumeBalance">WeeklyVolumeBalance.</param>
        /// <param name="weeklyVolumeOverride">WeeklyVolumeOverride.</param>
        /// <param name="weeklyVolumeThreshold">WeeklyVolumeThreshold.</param>
        /// <param name="monthlyVolume">MonthlyVolume.</param>
        /// <param name="monthlyVolumeAccumulated">MonthlyVolumeAccumulated.</param>
        /// <param name="monthlyVolumeBalance">MonthlyVolumeBalance.</param>
        /// <param name="monthlyVolumeOverride">MonthlyVolumeOverride.</param>
        /// <param name="monthlyVolumeThreshold">MonthlyVolumeThreshold.</param>
        /// <param name="perTransactionVolume">PerTransactionVolume.</param>
        /// <param name="perTransactionVolumeOverride">PerTransactionVolumeOverride.</param>
        /// <param name="annualVolume">AnnualVolume.</param>
        /// <param name="annualVolumeAccumulated">AnnualVolumeAccumulated.</param>
        /// <param name="annualVolumeBalance">AnnualVolumeBalance.</param>
        /// <param name="annualVolumeOverride">AnnualVolumeOverride.</param>
        /// <param name="annualVolumeThreshold">AnnualVolumeThreshold.</param>
        /// <param name="lifeTimeVolume">LifeTimeVolume.</param>
        /// <param name="lifeTimeVolumeAccumulated">LifeTimeVolumeAccumulated.</param>
        /// <param name="lifeTimeVolumeBalance">LifeTimeVolumeBalance.</param>
        /// <param name="lifeTimeVolumeOverride">LifeTimeVolumeOverride.</param>
        /// <param name="lifeTimeVolumeThreshold">LifeTimeVolumeThreshold.</param>
        /// <param name="dailyTransactionCount">DailyTransactionCount.</param>
        /// <param name="dailyTransactionAccumulated">DailyTransactionAccumulated.</param>
        /// <param name="dailyTransactionBalance">DailyTransactionBalance.</param>
        /// <param name="dailyTransactionOverride">DailyTransactionOverride.</param>
        /// <param name="dailyTransactionThreshold">DailyTransactionThreshold.</param>
        /// <param name="weeklyTransactionCount">WeeklyTransactionCount.</param>
        /// <param name="weeklyTransactionAccumulated">WeeklyTransactionAccumulated.</param>
        /// <param name="weeklyTransactionBalance">WeeklyTransactionBalance.</param>
        /// <param name="weeklyTransactionOverride">WeeklyTransactionOverride.</param>
        /// <param name="weeklyTransactionThreshold">WeeklyTransactionThreshold.</param>
        /// <param name="monthlyTransactionCount">MonthlyTransactionCount.</param>
        /// <param name="monthlyTransactionAccumulated">MonthlyTransactionAccumulated.</param>
        /// <param name="monthlyTransactionBalance">MonthlyTransactionBalance.</param>
        /// <param name="monthlyTransactionOverride">MonthlyTransactionOverride.</param>
        /// <param name="monthlyTransactionThreshold">MonthlyTransactionThreshold.</param>
        /// <param name="annualTransactionCount">AnnualTransactionCount.</param>
        /// <param name="annualTransactionAccumulated">AnnualTransactionAccumulated.</param>
        /// <param name="annualTransactionBalance">AnnualTransactionBalance.</param>
        /// <param name="annualTransactionOverride">AnnualTransactionOverride.</param>
        /// <param name="annualTransactionThreshold">AnnualTransactionThreshold.</param>
        /// <param name="lifeTimeTransactionCount">LifeTimeTransactionCount.</param>
        /// <param name="lifeTimeTransactionAccumulated">LifeTimeTransactionAccumulated.</param>
        /// <param name="lifeTimeTransactionBalance">LifeTimeTransactionBalance.</param>
        /// <param name="lifeTimeTransactionOverride">LifeTimeTransactionOverride.</param>
        /// <param name="lifeTimeTransactionThreshold">LifeTimeTransactionThreshold.</param>
        public UsageRestriction(
            string level = null,
            double? dailySpend = null,
            double? dailySpendAccumulated = null,
            double? dailySpendBalance = null,
            bool? dailySpendOverride = null,
            double? dailySpendThreshold = null,
            double? weeklySpend = null,
            double? weeklySpendAccumulated = null,
            double? weeklySpendBalance = null,
            bool? weeklySpendOverride = null,
            double? weeklySpendThreshold = null,
            double? monthlySpend = null,
            double? monthlySpendAccumulated = null,
            double? monthlySpendBalance = null,
            bool? monthlySpendOverride = null,
            double? perTransactionSpend = null,
            bool? perTransactionSpendOverride = null,
            double? annualSpend = null,
            double? annualSpendAccumulated = null,
            double? annualSpendBalance = null,
            bool? annualSpendOverride = null,
            double? annualSpendThreshold = null,
            double? lifeTimeSpend = null,
            double? lifeTimeSpendAccumulated = null,
            double? lifeTimeSpendBalance = null,
            bool? lifeTimeSpendOverride = null,
            double? lifeTimeSpendThreshold = null,
            double? dailyVolume = null,
            double? dailyVolumeAccumulated = null,
            double? dailyVolumeBalance = null,
            double? dailyVolumeOverride = null,
            double? dailyVolumeThreshold = null,
            double? weeklyVolume = null,
            double? weeklyVolumeAccumulated = null,
            double? weeklyVolumeBalance = null,
            bool? weeklyVolumeOverride = null,
            double? weeklyVolumeThreshold = null,
            double? monthlyVolume = null,
            double? monthlyVolumeAccumulated = null,
            double? monthlyVolumeBalance = null,
            bool? monthlyVolumeOverride = null,
            double? monthlyVolumeThreshold = null,
            double? perTransactionVolume = null,
            bool? perTransactionVolumeOverride = null,
            double? annualVolume = null,
            double? annualVolumeAccumulated = null,
            double? annualVolumeBalance = null,
            bool? annualVolumeOverride = null,
            double? annualVolumeThreshold = null,
            double? lifeTimeVolume = null,
            double? lifeTimeVolumeAccumulated = null,
            double? lifeTimeVolumeBalance = null,
            bool? lifeTimeVolumeOverride = null,
            double? lifeTimeVolumeThreshold = null,
            double? dailyTransactionCount = null,
            double? dailyTransactionAccumulated = null,
            double? dailyTransactionBalance = null,
            bool? dailyTransactionOverride = null,
            double? dailyTransactionThreshold = null,
            double? weeklyTransactionCount = null,
            double? weeklyTransactionAccumulated = null,
            double? weeklyTransactionBalance = null,
            bool? weeklyTransactionOverride = null,
            double? weeklyTransactionThreshold = null,
            double? monthlyTransactionCount = null,
            double? monthlyTransactionAccumulated = null,
            double? monthlyTransactionBalance = null,
            bool? monthlyTransactionOverride = null,
            double? monthlyTransactionThreshold = null,
            double? annualTransactionCount = null,
            double? annualTransactionAccumulated = null,
            double? annualTransactionBalance = null,
            bool? annualTransactionOverride = null,
            double? annualTransactionThreshold = null,
            double? lifeTimeTransactionCount = null,
            double? lifeTimeTransactionAccumulated = null,
            double? lifeTimeTransactionBalance = null,
            bool? lifeTimeTransactionOverride = null,
            double? lifeTimeTransactionThreshold = null)
        {
            this.Level = level;
            this.DailySpend = dailySpend;
            this.DailySpendAccumulated = dailySpendAccumulated;
            this.DailySpendBalance = dailySpendBalance;
            this.DailySpendOverride = dailySpendOverride;
            this.DailySpendThreshold = dailySpendThreshold;
            this.WeeklySpend = weeklySpend;
            this.WeeklySpendAccumulated = weeklySpendAccumulated;
            this.WeeklySpendBalance = weeklySpendBalance;
            this.WeeklySpendOverride = weeklySpendOverride;
            this.WeeklySpendThreshold = weeklySpendThreshold;
            this.MonthlySpend = monthlySpend;
            this.MonthlySpendAccumulated = monthlySpendAccumulated;
            this.MonthlySpendBalance = monthlySpendBalance;
            this.MonthlySpendOverride = monthlySpendOverride;
            this.PerTransactionSpend = perTransactionSpend;
            this.PerTransactionSpendOverride = perTransactionSpendOverride;
            this.AnnualSpend = annualSpend;
            this.AnnualSpendAccumulated = annualSpendAccumulated;
            this.AnnualSpendBalance = annualSpendBalance;
            this.AnnualSpendOverride = annualSpendOverride;
            this.AnnualSpendThreshold = annualSpendThreshold;
            this.LifeTimeSpend = lifeTimeSpend;
            this.LifeTimeSpendAccumulated = lifeTimeSpendAccumulated;
            this.LifeTimeSpendBalance = lifeTimeSpendBalance;
            this.LifeTimeSpendOverride = lifeTimeSpendOverride;
            this.LifeTimeSpendThreshold = lifeTimeSpendThreshold;
            this.DailyVolume = dailyVolume;
            this.DailyVolumeAccumulated = dailyVolumeAccumulated;
            this.DailyVolumeBalance = dailyVolumeBalance;
            this.DailyVolumeOverride = dailyVolumeOverride;
            this.DailyVolumeThreshold = dailyVolumeThreshold;
            this.WeeklyVolume = weeklyVolume;
            this.WeeklyVolumeAccumulated = weeklyVolumeAccumulated;
            this.WeeklyVolumeBalance = weeklyVolumeBalance;
            this.WeeklyVolumeOverride = weeklyVolumeOverride;
            this.WeeklyVolumeThreshold = weeklyVolumeThreshold;
            this.MonthlyVolume = monthlyVolume;
            this.MonthlyVolumeAccumulated = monthlyVolumeAccumulated;
            this.MonthlyVolumeBalance = monthlyVolumeBalance;
            this.MonthlyVolumeOverride = monthlyVolumeOverride;
            this.MonthlyVolumeThreshold = monthlyVolumeThreshold;
            this.PerTransactionVolume = perTransactionVolume;
            this.PerTransactionVolumeOverride = perTransactionVolumeOverride;
            this.AnnualVolume = annualVolume;
            this.AnnualVolumeAccumulated = annualVolumeAccumulated;
            this.AnnualVolumeBalance = annualVolumeBalance;
            this.AnnualVolumeOverride = annualVolumeOverride;
            this.AnnualVolumeThreshold = annualVolumeThreshold;
            this.LifeTimeVolume = lifeTimeVolume;
            this.LifeTimeVolumeAccumulated = lifeTimeVolumeAccumulated;
            this.LifeTimeVolumeBalance = lifeTimeVolumeBalance;
            this.LifeTimeVolumeOverride = lifeTimeVolumeOverride;
            this.LifeTimeVolumeThreshold = lifeTimeVolumeThreshold;
            this.DailyTransactionCount = dailyTransactionCount;
            this.DailyTransactionAccumulated = dailyTransactionAccumulated;
            this.DailyTransactionBalance = dailyTransactionBalance;
            this.DailyTransactionOverride = dailyTransactionOverride;
            this.DailyTransactionThreshold = dailyTransactionThreshold;
            this.WeeklyTransactionCount = weeklyTransactionCount;
            this.WeeklyTransactionAccumulated = weeklyTransactionAccumulated;
            this.WeeklyTransactionBalance = weeklyTransactionBalance;
            this.WeeklyTransactionOverride = weeklyTransactionOverride;
            this.WeeklyTransactionThreshold = weeklyTransactionThreshold;
            this.MonthlyTransactionCount = monthlyTransactionCount;
            this.MonthlyTransactionAccumulated = monthlyTransactionAccumulated;
            this.MonthlyTransactionBalance = monthlyTransactionBalance;
            this.MonthlyTransactionOverride = monthlyTransactionOverride;
            this.MonthlyTransactionThreshold = monthlyTransactionThreshold;
            this.AnnualTransactionCount = annualTransactionCount;
            this.AnnualTransactionAccumulated = annualTransactionAccumulated;
            this.AnnualTransactionBalance = annualTransactionBalance;
            this.AnnualTransactionOverride = annualTransactionOverride;
            this.AnnualTransactionThreshold = annualTransactionThreshold;
            this.LifeTimeTransactionCount = lifeTimeTransactionCount;
            this.LifeTimeTransactionAccumulated = lifeTimeTransactionAccumulated;
            this.LifeTimeTransactionBalance = lifeTimeTransactionBalance;
            this.LifeTimeTransactionOverride = lifeTimeTransactionOverride;
            this.LifeTimeTransactionThreshold = lifeTimeTransactionThreshold;
        }

        /// <summary>
        /// Usage limit is applied on the card from this level.
        /// Valid values –
        /// •	Inherited
        /// •	Card
        /// When Card level usage restrictions are not present, the API will return the inherited restrictions.
        /// Note: -This field is deprecated. Instead, use ‘Override’.
        /// </summary>
        [JsonProperty("Level", NullValueHandling = NullValueHandling.Ignore)]
        public string Level { get; set; }

        /// <summary>
        /// Maximum spend value (amount) allowed per day.
        /// Card limit ‘0’ represents the value is inherited and inherited limit could be calculated by adding accumulated and balance.
        /// However, Inherited limit ‘0’ represents unlimited.
        /// </summary>
        [JsonProperty("DailySpend", NullValueHandling = NullValueHandling.Ignore)]
        public double? DailySpend { get; set; }

        /// <summary>
        /// Balance spend value (amount) available for rest of the day.
        /// </summary>
        [JsonProperty("DailySpendAccumulated", NullValueHandling = NullValueHandling.Ignore)]
        public double? DailySpendAccumulated { get; set; }

        /// <summary>
        /// Balance spend value (amount) available for rest of the day.
        /// </summary>
        [JsonProperty("DailySpendBalance", NullValueHandling = NullValueHandling.Ignore)]
        public double? DailySpendBalance { get; set; }

        /// <summary>
        /// Indicate if the limit is overridden or default. (False for default).
        /// Example: false
        /// </summary>
        [JsonProperty("DailySpendOverride", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DailySpendOverride { get; set; }

        /// <summary>
        /// The limit to trigger an alert if the balance after a transaction reaches it or below. 0 indicates no alerts will be sent. Not present if not set (issuer value threshold limit applies if available). Not present for COUNT type velocity.
        /// Example: 50.55
        /// </summary>
        [JsonProperty("DailySpendThreshold", NullValueHandling = NullValueHandling.Ignore)]
        public double? DailySpendThreshold { get; set; }

        /// <summary>
        /// Maximum spend value (amount) allowed per week.
        /// Card limit ‘0’ represents the value is inherited and inherited limit could be calculated by adding accumulated and balance.
        /// However, Inherited limit ‘0’ represents unlimited.
        /// </summary>
        [JsonProperty("WeeklySpend", NullValueHandling = NullValueHandling.Ignore)]
        public double? WeeklySpend { get; set; }

        /// <summary>
        /// Value (amount) spent during the week.
        /// </summary>
        [JsonProperty("WeeklySpendAccumulated", NullValueHandling = NullValueHandling.Ignore)]
        public double? WeeklySpendAccumulated { get; set; }

        /// <summary>
        /// Balance spend value (amount) available for rest of the week.
        /// </summary>
        [JsonProperty("WeeklySpendBalance", NullValueHandling = NullValueHandling.Ignore)]
        public double? WeeklySpendBalance { get; set; }

        /// <summary>
        /// Indicate if the limit is overridden or default. (False for default).
        /// Example: false
        /// </summary>
        [JsonProperty("WeeklySpendOverride", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WeeklySpendOverride { get; set; }

        /// <summary>
        /// The limit to trigger an alert if the balance after a transaction reaches it or below. 0 indicates no alerts will be sent. Not present if not set (issuer value threshold limit applies if available). Not present for COUNT type velocity.
        /// Example: 50.55
        /// This is an optional output field.
        /// </summary>
        [JsonProperty("WeeklySpendThreshold", NullValueHandling = NullValueHandling.Ignore)]
        public double? WeeklySpendThreshold { get; set; }

        /// <summary>
        /// Maximum spend value (amount) allowed per month.
        /// Card limit ‘0’ represents the value is inherited and inherited limit could be calculated by adding accumulated and balance.
        /// However, Inherited limit ‘0’ represents unlimited.
        /// </summary>
        [JsonProperty("MonthlySpend", NullValueHandling = NullValueHandling.Ignore)]
        public double? MonthlySpend { get; set; }

        /// <summary>
        /// Value (amount) spent during the month.
        /// </summary>
        [JsonProperty("MonthlySpendAccumulated", NullValueHandling = NullValueHandling.Ignore)]
        public double? MonthlySpendAccumulated { get; set; }

        /// <summary>
        /// Balance spend value (amount) available for rest of the month.
        /// </summary>
        [JsonProperty("MonthlySpendBalance", NullValueHandling = NullValueHandling.Ignore)]
        public double? MonthlySpendBalance { get; set; }

        /// <summary>
        /// Indicate if the limit is overridden or default. (False for default).
        /// Example: false
        /// </summary>
        [JsonProperty("MonthlySpendOverride", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MonthlySpendOverride { get; set; }

        /// <summary>
        /// Maximum spend value (amount) allowed per transaction.
        /// Card limit ‘0’ represents the value is inherited and inherited limit could be calculated by adding accumulated and balance.
        /// However, Inherited limit ‘0’ represents unlimited.
        /// </summary>
        [JsonProperty("PerTransactionSpend", NullValueHandling = NullValueHandling.Ignore)]
        public double? PerTransactionSpend { get; set; }

        /// <summary>
        /// Indicate if the limit is overridden or default. (False for default).
        /// Example: false
        /// </summary>
        [JsonProperty("PerTransactionSpendOverride", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PerTransactionSpendOverride { get; set; }

        /// <summary>
        /// Maximum spend value (amount) allowed per annum.
        /// Card limit ‘0’ represents the value is inherited and inherited limit could be calculated by adding accumulated and balance.
        /// However, Inherited limit ‘0’ represents unlimited.
        /// </summary>
        [JsonProperty("AnnualSpend", NullValueHandling = NullValueHandling.Ignore)]
        public double? AnnualSpend { get; set; }

        /// <summary>
        /// Value (amount) spent during the year.
        /// </summary>
        [JsonProperty("AnnualSpendAccumulated", NullValueHandling = NullValueHandling.Ignore)]
        public double? AnnualSpendAccumulated { get; set; }

        /// <summary>
        /// Balance spend value (amount) available for rest of the year.
        /// </summary>
        [JsonProperty("AnnualSpendBalance", NullValueHandling = NullValueHandling.Ignore)]
        public double? AnnualSpendBalance { get; set; }

        /// <summary>
        /// Indicate if the limit is overridden or default. (False for default).
        /// Example: false
        /// </summary>
        [JsonProperty("AnnualSpendOverride", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AnnualSpendOverride { get; set; }

        /// <summary>
        /// The limit to trigger an alert if the balance after a transaction reaches it or below. 0 indicates no alerts will be sent. Not present if not set (issuer value threshold limit applies if available). Not present for COUNT type velocity.
        /// Example: 50.55
        /// This is an optional output field.
        /// </summary>
        [JsonProperty("AnnualSpendThreshold", NullValueHandling = NullValueHandling.Ignore)]
        public double? AnnualSpendThreshold { get; set; }

        /// <summary>
        /// Maximum spend value (amount) allowed in card’s life time.
        /// Card limit ‘0’ represents the value is inherited and inherited limit could be calculated by adding accumulated and balance.
        /// However, Inherited limit ‘0’ represents unlimited
        /// </summary>
        [JsonProperty("LifeTimeSpend", NullValueHandling = NullValueHandling.Ignore)]
        public double? LifeTimeSpend { get; set; }

        /// <summary>
        /// Value (amount) spent during the card’s life time
        /// </summary>
        [JsonProperty("LifeTimeSpendAccumulated", NullValueHandling = NullValueHandling.Ignore)]
        public double? LifeTimeSpendAccumulated { get; set; }

        /// <summary>
        /// Balance spend value (amount) available for rest of the card’s life time.
        /// </summary>
        [JsonProperty("LifeTimeSpendBalance", NullValueHandling = NullValueHandling.Ignore)]
        public double? LifeTimeSpendBalance { get; set; }

        /// <summary>
        /// Indicate if the limit is overridden or default. (False for default).
        /// Example: false
        /// </summary>
        [JsonProperty("LifeTimeSpendOverride", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LifeTimeSpendOverride { get; set; }

        /// <summary>
        /// The limit to trigger an alert if the balance after a transaction reaches it or below. 0 indicates no alerts will be sent. Not present if not set (issuer value threshold limit applies if available). Not present for COUNT type velocity.
        /// Example: 50.55
        /// This is an optional output field.
        /// </summary>
        [JsonProperty("LifeTimeSpendThreshold", NullValueHandling = NullValueHandling.Ignore)]
        public double? LifeTimeSpendThreshold { get; set; }

        /// <summary>
        /// Maximum volume (quantity) allowed per day.
        /// Card limit ‘0’ represents the value is inherited and inherited limit could be calculated by adding accumulated and balance.
        /// However, Inherited limit ‘0’ represents unlimited.
        /// </summary>
        [JsonProperty("DailyVolume", NullValueHandling = NullValueHandling.Ignore)]
        public double? DailyVolume { get; set; }

        /// <summary>
        /// Volume (quantity) bought during the day.
        /// </summary>
        [JsonProperty("DailyVolumeAccumulated", NullValueHandling = NullValueHandling.Ignore)]
        public double? DailyVolumeAccumulated { get; set; }

        /// <summary>
        /// Balance volume (quantity) available for rest of the day.
        /// </summary>
        [JsonProperty("DailyVolumeBalance", NullValueHandling = NullValueHandling.Ignore)]
        public double? DailyVolumeBalance { get; set; }

        /// <summary>
        /// Indicate if the limit is overridden or default. (False for default).
        /// Example: false
        /// </summary>
        [JsonProperty("DailyVolumeOverride", NullValueHandling = NullValueHandling.Ignore)]
        public double? DailyVolumeOverride { get; set; }

        /// <summary>
        /// The limit to trigger an alert if the balance after a transaction reaches it or below. 0 indicates no alerts will be sent. Not present if not set (issuer value threshold limit applies if available). Not present for COUNT type velocity.
        /// Example: 50.55
        /// This is an optional output field.
        /// </summary>
        [JsonProperty("DailyVolumeThreshold", NullValueHandling = NullValueHandling.Ignore)]
        public double? DailyVolumeThreshold { get; set; }

        /// <summary>
        /// Maximum volume (quantity) allowed per week.
        /// Card limit ‘0’ represents the value is inherited and inherited limit could be calculated by adding accumulated and balance.
        /// However, Inherited limit ‘0’ represents unlimited.
        /// </summary>
        [JsonProperty("WeeklyVolume", NullValueHandling = NullValueHandling.Ignore)]
        public double? WeeklyVolume { get; set; }

        /// <summary>
        /// Volume (quantity) bought during the week.
        /// </summary>
        [JsonProperty("WeeklyVolumeAccumulated", NullValueHandling = NullValueHandling.Ignore)]
        public double? WeeklyVolumeAccumulated { get; set; }

        /// <summary>
        /// Balance volume (quantity) available for rest of the week.
        /// </summary>
        [JsonProperty("WeeklyVolumeBalance", NullValueHandling = NullValueHandling.Ignore)]
        public double? WeeklyVolumeBalance { get; set; }

        /// <summary>
        /// Indicate if the limit is overridden or default. (False for default).
        /// Example: false
        /// </summary>
        [JsonProperty("WeeklyVolumeOverride", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WeeklyVolumeOverride { get; set; }

        /// <summary>
        /// The limit to trigger an alert if the balance after a transaction reaches it or below. 0 indicates no alerts will be sent. Not present if not set (issuer value threshold limit applies if available). Not present for COUNT type velocity.
        /// Example: 50.55
        /// This is an optional output field.
        /// </summary>
        [JsonProperty("WeeklyVolumeThreshold", NullValueHandling = NullValueHandling.Ignore)]
        public double? WeeklyVolumeThreshold { get; set; }

        /// <summary>
        /// Maximum volume (quantity) allowed per month.
        /// Card limit ‘0’ represents the value is inherited and inherited limit could be calculated by adding accumulated and balance.
        /// However, Inherited limit ‘0’ represents unlimited.
        /// </summary>
        [JsonProperty("MonthlyVolume", NullValueHandling = NullValueHandling.Ignore)]
        public double? MonthlyVolume { get; set; }

        /// <summary>
        /// Volume (quantity) bought during the month.
        /// </summary>
        [JsonProperty("MonthlyVolumeAccumulated", NullValueHandling = NullValueHandling.Ignore)]
        public double? MonthlyVolumeAccumulated { get; set; }

        /// <summary>
        /// Balance volume (quantity) available for rest of the month.
        /// </summary>
        [JsonProperty("MonthlyVolumeBalance", NullValueHandling = NullValueHandling.Ignore)]
        public double? MonthlyVolumeBalance { get; set; }

        /// <summary>
        /// Indicate if the limit is overridden or default. (False for default).
        /// </summary>
        [JsonProperty("MonthlyVolumeOverride", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MonthlyVolumeOverride { get; set; }

        /// <summary>
        /// The limit to trigger an alert if the balance after a transaction reaches it or below. 0 indicates no alerts will be sent. Not present if not set (issuer value threshold limit applies if available). Not present for COUNT type velocity.
        /// Example: 50.55
        /// This is an optional output field.
        /// </summary>
        [JsonProperty("MonthlyVolumeThreshold", NullValueHandling = NullValueHandling.Ignore)]
        public double? MonthlyVolumeThreshold { get; set; }

        /// <summary>
        /// Maximum volume (quantity) allowed per transaction.
        /// Card limit ‘0’ represents the value is inherited and inherited limit could be calculated by adding accumulated and balance.
        /// However, Inherited limit ‘0’ represents unlimited.
        /// </summary>
        [JsonProperty("PerTransactionVolume", NullValueHandling = NullValueHandling.Ignore)]
        public double? PerTransactionVolume { get; set; }

        /// <summary>
        /// Indicate if the limit is overridden or default. (False for default).
        /// Example: false
        /// </summary>
        [JsonProperty("PerTransactionVolumeOverride", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PerTransactionVolumeOverride { get; set; }

        /// <summary>
        /// Maximum volume (quantity) allowed per annum.
        /// Card limit ‘0’ represents the value is inherited and inherited limit could be calculated by adding accumulated and balance.
        /// However, Inherited limit ‘0’ represents unlimited.
        /// </summary>
        [JsonProperty("AnnualVolume", NullValueHandling = NullValueHandling.Ignore)]
        public double? AnnualVolume { get; set; }

        /// <summary>
        /// Volume (quantity) bought during the year.
        /// </summary>
        [JsonProperty("AnnualVolumeAccumulated", NullValueHandling = NullValueHandling.Ignore)]
        public double? AnnualVolumeAccumulated { get; set; }

        /// <summary>
        /// Balance volume (quantity) available for rest of the year.
        /// </summary>
        [JsonProperty("AnnualVolumeBalance", NullValueHandling = NullValueHandling.Ignore)]
        public double? AnnualVolumeBalance { get; set; }

        /// <summary>
        /// Indicate if the limit is overridden or default. (False for default).
        /// Example: false
        /// </summary>
        [JsonProperty("AnnualVolumeOverride", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AnnualVolumeOverride { get; set; }

        /// <summary>
        /// The limit to trigger an alert if the balance after a transaction reaches it or below. 0 indicates no alerts will be sent. Not present if not set (issuer value threshold limit applies if available). Not present for COUNT type velocity.
        /// Example: 50.55
        /// This is an optional output field.
        /// </summary>
        [JsonProperty("AnnualVolumeThreshold", NullValueHandling = NullValueHandling.Ignore)]
        public double? AnnualVolumeThreshold { get; set; }

        /// <summary>
        /// Maximum volume (quantity) allowed in the card’s life time.
        /// Card limit ‘0’ represents the value is inherited and inherited limit could be calculated by adding accumulated and balance.
        /// However, Inherited limit ‘0’ represents unlimited.
        /// </summary>
        [JsonProperty("LifeTimeVolume", NullValueHandling = NullValueHandling.Ignore)]
        public double? LifeTimeVolume { get; set; }

        /// <summary>
        /// Volume (quantity) bought during the card’s life time.
        /// </summary>
        [JsonProperty("LifeTimeVolumeAccumulated", NullValueHandling = NullValueHandling.Ignore)]
        public double? LifeTimeVolumeAccumulated { get; set; }

        /// <summary>
        /// Balance volume (quantity) available for rest of the card’s life time.
        /// </summary>
        [JsonProperty("LifeTimeVolumeBalance", NullValueHandling = NullValueHandling.Ignore)]
        public double? LifeTimeVolumeBalance { get; set; }

        /// <summary>
        /// Indicate if the limit is overridden or default. (False for default).
        /// Example: false
        /// </summary>
        [JsonProperty("LifeTimeVolumeOverride", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LifeTimeVolumeOverride { get; set; }

        /// <summary>
        /// The limit to trigger an alert if the balance after a transaction reaches it or below. 0 indicates no alerts will be sent. Not present if not set (issuer value threshold limit applies if available). Not present for COUNT type velocity.
        /// Example: 50.55
        /// This is an optional output field.
        /// </summary>
        [JsonProperty("LifeTimeVolumeThreshold", NullValueHandling = NullValueHandling.Ignore)]
        public double? LifeTimeVolumeThreshold { get; set; }

        /// <summary>
        /// Maximum number of transactions allowed per day.
        /// Card limit ‘0’ represents the value is inherited and inherited limit could be calculated by adding accumulated and balance.
        /// However, Inherited limit ‘0’ represents unlimited
        /// </summary>
        [JsonProperty("DailyTransactionCount", NullValueHandling = NullValueHandling.Ignore)]
        public double? DailyTransactionCount { get; set; }

        /// <summary>
        /// Number of times the card is used during the day.
        /// </summary>
        [JsonProperty("DailyTransactionAccumulated", NullValueHandling = NullValueHandling.Ignore)]
        public double? DailyTransactionAccumulated { get; set; }

        /// <summary>
        /// Number of times the card could be used in rest of the day.
        /// </summary>
        [JsonProperty("DailyTransactionBalance", NullValueHandling = NullValueHandling.Ignore)]
        public double? DailyTransactionBalance { get; set; }

        /// <summary>
        /// Indicate if the limit is overridden or default. (False for default).
        /// Example: false
        /// </summary>
        [JsonProperty("DailyTransactionOverride", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DailyTransactionOverride { get; set; }

        /// <summary>
        /// The limit to trigger an alert if the balance after a transaction reaches it or below. 0 indicates no alerts will be sent. Not present if not set (issuer value threshold limit applies if available). Not present for COUNT type velocity.
        /// Example: 50.55
        /// This is an optional output field.
        /// </summary>
        [JsonProperty("DailyTransactionThreshold", NullValueHandling = NullValueHandling.Ignore)]
        public double? DailyTransactionThreshold { get; set; }

        /// <summary>
        /// Maximum number of transactions allowed per week.
        /// Card limit ‘0’ represents the value is inherited and inherited limit could be calculated by adding accumulated and balance.
        /// However, Inherited limit ‘0’ represents unlimited.
        /// </summary>
        [JsonProperty("WeeklyTransactionCount", NullValueHandling = NullValueHandling.Ignore)]
        public double? WeeklyTransactionCount { get; set; }

        /// <summary>
        /// Number of times the card is used during the week
        /// </summary>
        [JsonProperty("WeeklyTransactionAccumulated", NullValueHandling = NullValueHandling.Ignore)]
        public double? WeeklyTransactionAccumulated { get; set; }

        /// <summary>
        /// Number of times the card could be used in rest of the week.
        /// </summary>
        [JsonProperty("WeeklyTransactionBalance", NullValueHandling = NullValueHandling.Ignore)]
        public double? WeeklyTransactionBalance { get; set; }

        /// <summary>
        /// Indicate if the limit is overridden or default. (False for default).
        /// Example: false
        /// </summary>
        [JsonProperty("WeeklyTransactionOverride", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WeeklyTransactionOverride { get; set; }

        /// <summary>
        /// The limit to trigger an alert if the balance after a transaction reaches it or below. 0 indicates no alerts will be sent. Not present if not set (issuer value threshold limit applies if available). Not present for COUNT type velocity.
        /// Example: 50.55
        /// This is an optional output field.
        /// </summary>
        [JsonProperty("WeeklyTransactionThreshold", NullValueHandling = NullValueHandling.Ignore)]
        public double? WeeklyTransactionThreshold { get; set; }

        /// <summary>
        /// Maximum number of transactions allowed per month.
        /// Card limit ‘0’ represents the value is inherited and inherited limit could be calculated by adding accumulated and balance.
        /// However, Inherited limit ‘0’ represents unlimited.
        /// </summary>
        [JsonProperty("MonthlyTransactionCount", NullValueHandling = NullValueHandling.Ignore)]
        public double? MonthlyTransactionCount { get; set; }

        /// <summary>
        /// Number of times the card is used during the month
        /// </summary>
        [JsonProperty("MonthlyTransactionAccumulated", NullValueHandling = NullValueHandling.Ignore)]
        public double? MonthlyTransactionAccumulated { get; set; }

        /// <summary>
        /// Number of times the card could be used in rest of the month.
        /// </summary>
        [JsonProperty("MonthlyTransactionBalance", NullValueHandling = NullValueHandling.Ignore)]
        public double? MonthlyTransactionBalance { get; set; }

        /// <summary>
        /// Indicate if the limit is overridden or default. (False for default).
        /// Example: false
        /// </summary>
        [JsonProperty("MonthlyTransactionOverride", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MonthlyTransactionOverride { get; set; }

        /// <summary>
        /// The limit to trigger an alert if the balance after a transaction reaches it or below. 0 indicates no alerts will be sent. Not present if not set (issuer value threshold limit applies if available). Not present for COUNT type velocity.
        /// Example: 50.55
        /// This is an optional output field.
        /// </summary>
        [JsonProperty("MonthlyTransactionThreshold", NullValueHandling = NullValueHandling.Ignore)]
        public double? MonthlyTransactionThreshold { get; set; }

        /// <summary>
        /// Maximum number of transactions allowed per annum.
        /// Card limit ‘0’ represents the value is inherited and inherited limit could be calculated by adding accumulated and balance.
        /// </summary>
        [JsonProperty("AnnualTransactionCount", NullValueHandling = NullValueHandling.Ignore)]
        public double? AnnualTransactionCount { get; set; }

        /// <summary>
        /// Number of times the card is used during the year.
        /// </summary>
        [JsonProperty("AnnualTransactionAccumulated", NullValueHandling = NullValueHandling.Ignore)]
        public double? AnnualTransactionAccumulated { get; set; }

        /// <summary>
        /// Number of times the card could be used in rest of the year.
        /// </summary>
        [JsonProperty("AnnualTransactionBalance", NullValueHandling = NullValueHandling.Ignore)]
        public double? AnnualTransactionBalance { get; set; }

        /// <summary>
        /// Indicate if the limit is overridden or default. (False for default).
        /// Example: false
        /// </summary>
        [JsonProperty("AnnualTransactionOverride", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AnnualTransactionOverride { get; set; }

        /// <summary>
        /// The limit to trigger an alert if the balance after a transaction reaches it or below. 0 indicates no alerts will be sent. Not present if not set (issuer value threshold limit applies if available). Not present for COUNT type velocity.
        /// Example: 50.55
        /// This is an optional output field.
        /// </summary>
        [JsonProperty("AnnualTransactionThreshold", NullValueHandling = NullValueHandling.Ignore)]
        public double? AnnualTransactionThreshold { get; set; }

        /// <summary>
        /// Maximum number of transactions allowed in the card’s life time.
        /// Card limit ‘0’ represents the value is inherited and inherited limit could be calculated by adding accumulated and balance.
        /// However, Inherited limit ‘0’ represents unlimited.
        /// </summary>
        [JsonProperty("LifeTimeTransactionCount", NullValueHandling = NullValueHandling.Ignore)]
        public double? LifeTimeTransactionCount { get; set; }

        /// <summary>
        /// Number of times the card is used during the card’s life time.
        /// </summary>
        [JsonProperty("LifeTimeTransactionAccumulated", NullValueHandling = NullValueHandling.Ignore)]
        public double? LifeTimeTransactionAccumulated { get; set; }

        /// <summary>
        /// Number of times the card could be used in rest of the card’s life time.
        /// </summary>
        [JsonProperty("LifeTimeTransactionBalance", NullValueHandling = NullValueHandling.Ignore)]
        public double? LifeTimeTransactionBalance { get; set; }

        /// <summary>
        /// Indicate if the limit is overridden or default. (False for default).
        /// Example: false
        /// </summary>
        [JsonProperty("LifeTimeTransactionOverride", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LifeTimeTransactionOverride { get; set; }

        /// <summary>
        /// The limit to trigger an alert if the balance after a transaction reaches it or below. 0 indicates no alerts will be sent. Not present if not set (issuer value threshold limit applies if available). Not present for COUNT type velocity.
        /// Example: 50.55
        /// This is an optional output field.
        /// </summary>
        [JsonProperty("LifeTimeTransactionThreshold", NullValueHandling = NullValueHandling.Ignore)]
        public double? LifeTimeTransactionThreshold { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UsageRestriction : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is UsageRestriction other &&                ((this.Level == null && other.Level == null) || (this.Level?.Equals(other.Level) == true)) &&
                ((this.DailySpend == null && other.DailySpend == null) || (this.DailySpend?.Equals(other.DailySpend) == true)) &&
                ((this.DailySpendAccumulated == null && other.DailySpendAccumulated == null) || (this.DailySpendAccumulated?.Equals(other.DailySpendAccumulated) == true)) &&
                ((this.DailySpendBalance == null && other.DailySpendBalance == null) || (this.DailySpendBalance?.Equals(other.DailySpendBalance) == true)) &&
                ((this.DailySpendOverride == null && other.DailySpendOverride == null) || (this.DailySpendOverride?.Equals(other.DailySpendOverride) == true)) &&
                ((this.DailySpendThreshold == null && other.DailySpendThreshold == null) || (this.DailySpendThreshold?.Equals(other.DailySpendThreshold) == true)) &&
                ((this.WeeklySpend == null && other.WeeklySpend == null) || (this.WeeklySpend?.Equals(other.WeeklySpend) == true)) &&
                ((this.WeeklySpendAccumulated == null && other.WeeklySpendAccumulated == null) || (this.WeeklySpendAccumulated?.Equals(other.WeeklySpendAccumulated) == true)) &&
                ((this.WeeklySpendBalance == null && other.WeeklySpendBalance == null) || (this.WeeklySpendBalance?.Equals(other.WeeklySpendBalance) == true)) &&
                ((this.WeeklySpendOverride == null && other.WeeklySpendOverride == null) || (this.WeeklySpendOverride?.Equals(other.WeeklySpendOverride) == true)) &&
                ((this.WeeklySpendThreshold == null && other.WeeklySpendThreshold == null) || (this.WeeklySpendThreshold?.Equals(other.WeeklySpendThreshold) == true)) &&
                ((this.MonthlySpend == null && other.MonthlySpend == null) || (this.MonthlySpend?.Equals(other.MonthlySpend) == true)) &&
                ((this.MonthlySpendAccumulated == null && other.MonthlySpendAccumulated == null) || (this.MonthlySpendAccumulated?.Equals(other.MonthlySpendAccumulated) == true)) &&
                ((this.MonthlySpendBalance == null && other.MonthlySpendBalance == null) || (this.MonthlySpendBalance?.Equals(other.MonthlySpendBalance) == true)) &&
                ((this.MonthlySpendOverride == null && other.MonthlySpendOverride == null) || (this.MonthlySpendOverride?.Equals(other.MonthlySpendOverride) == true)) &&
                ((this.PerTransactionSpend == null && other.PerTransactionSpend == null) || (this.PerTransactionSpend?.Equals(other.PerTransactionSpend) == true)) &&
                ((this.PerTransactionSpendOverride == null && other.PerTransactionSpendOverride == null) || (this.PerTransactionSpendOverride?.Equals(other.PerTransactionSpendOverride) == true)) &&
                ((this.AnnualSpend == null && other.AnnualSpend == null) || (this.AnnualSpend?.Equals(other.AnnualSpend) == true)) &&
                ((this.AnnualSpendAccumulated == null && other.AnnualSpendAccumulated == null) || (this.AnnualSpendAccumulated?.Equals(other.AnnualSpendAccumulated) == true)) &&
                ((this.AnnualSpendBalance == null && other.AnnualSpendBalance == null) || (this.AnnualSpendBalance?.Equals(other.AnnualSpendBalance) == true)) &&
                ((this.AnnualSpendOverride == null && other.AnnualSpendOverride == null) || (this.AnnualSpendOverride?.Equals(other.AnnualSpendOverride) == true)) &&
                ((this.AnnualSpendThreshold == null && other.AnnualSpendThreshold == null) || (this.AnnualSpendThreshold?.Equals(other.AnnualSpendThreshold) == true)) &&
                ((this.LifeTimeSpend == null && other.LifeTimeSpend == null) || (this.LifeTimeSpend?.Equals(other.LifeTimeSpend) == true)) &&
                ((this.LifeTimeSpendAccumulated == null && other.LifeTimeSpendAccumulated == null) || (this.LifeTimeSpendAccumulated?.Equals(other.LifeTimeSpendAccumulated) == true)) &&
                ((this.LifeTimeSpendBalance == null && other.LifeTimeSpendBalance == null) || (this.LifeTimeSpendBalance?.Equals(other.LifeTimeSpendBalance) == true)) &&
                ((this.LifeTimeSpendOverride == null && other.LifeTimeSpendOverride == null) || (this.LifeTimeSpendOverride?.Equals(other.LifeTimeSpendOverride) == true)) &&
                ((this.LifeTimeSpendThreshold == null && other.LifeTimeSpendThreshold == null) || (this.LifeTimeSpendThreshold?.Equals(other.LifeTimeSpendThreshold) == true)) &&
                ((this.DailyVolume == null && other.DailyVolume == null) || (this.DailyVolume?.Equals(other.DailyVolume) == true)) &&
                ((this.DailyVolumeAccumulated == null && other.DailyVolumeAccumulated == null) || (this.DailyVolumeAccumulated?.Equals(other.DailyVolumeAccumulated) == true)) &&
                ((this.DailyVolumeBalance == null && other.DailyVolumeBalance == null) || (this.DailyVolumeBalance?.Equals(other.DailyVolumeBalance) == true)) &&
                ((this.DailyVolumeOverride == null && other.DailyVolumeOverride == null) || (this.DailyVolumeOverride?.Equals(other.DailyVolumeOverride) == true)) &&
                ((this.DailyVolumeThreshold == null && other.DailyVolumeThreshold == null) || (this.DailyVolumeThreshold?.Equals(other.DailyVolumeThreshold) == true)) &&
                ((this.WeeklyVolume == null && other.WeeklyVolume == null) || (this.WeeklyVolume?.Equals(other.WeeklyVolume) == true)) &&
                ((this.WeeklyVolumeAccumulated == null && other.WeeklyVolumeAccumulated == null) || (this.WeeklyVolumeAccumulated?.Equals(other.WeeklyVolumeAccumulated) == true)) &&
                ((this.WeeklyVolumeBalance == null && other.WeeklyVolumeBalance == null) || (this.WeeklyVolumeBalance?.Equals(other.WeeklyVolumeBalance) == true)) &&
                ((this.WeeklyVolumeOverride == null && other.WeeklyVolumeOverride == null) || (this.WeeklyVolumeOverride?.Equals(other.WeeklyVolumeOverride) == true)) &&
                ((this.WeeklyVolumeThreshold == null && other.WeeklyVolumeThreshold == null) || (this.WeeklyVolumeThreshold?.Equals(other.WeeklyVolumeThreshold) == true)) &&
                ((this.MonthlyVolume == null && other.MonthlyVolume == null) || (this.MonthlyVolume?.Equals(other.MonthlyVolume) == true)) &&
                ((this.MonthlyVolumeAccumulated == null && other.MonthlyVolumeAccumulated == null) || (this.MonthlyVolumeAccumulated?.Equals(other.MonthlyVolumeAccumulated) == true)) &&
                ((this.MonthlyVolumeBalance == null && other.MonthlyVolumeBalance == null) || (this.MonthlyVolumeBalance?.Equals(other.MonthlyVolumeBalance) == true)) &&
                ((this.MonthlyVolumeOverride == null && other.MonthlyVolumeOverride == null) || (this.MonthlyVolumeOverride?.Equals(other.MonthlyVolumeOverride) == true)) &&
                ((this.MonthlyVolumeThreshold == null && other.MonthlyVolumeThreshold == null) || (this.MonthlyVolumeThreshold?.Equals(other.MonthlyVolumeThreshold) == true)) &&
                ((this.PerTransactionVolume == null && other.PerTransactionVolume == null) || (this.PerTransactionVolume?.Equals(other.PerTransactionVolume) == true)) &&
                ((this.PerTransactionVolumeOverride == null && other.PerTransactionVolumeOverride == null) || (this.PerTransactionVolumeOverride?.Equals(other.PerTransactionVolumeOverride) == true)) &&
                ((this.AnnualVolume == null && other.AnnualVolume == null) || (this.AnnualVolume?.Equals(other.AnnualVolume) == true)) &&
                ((this.AnnualVolumeAccumulated == null && other.AnnualVolumeAccumulated == null) || (this.AnnualVolumeAccumulated?.Equals(other.AnnualVolumeAccumulated) == true)) &&
                ((this.AnnualVolumeBalance == null && other.AnnualVolumeBalance == null) || (this.AnnualVolumeBalance?.Equals(other.AnnualVolumeBalance) == true)) &&
                ((this.AnnualVolumeOverride == null && other.AnnualVolumeOverride == null) || (this.AnnualVolumeOverride?.Equals(other.AnnualVolumeOverride) == true)) &&
                ((this.AnnualVolumeThreshold == null && other.AnnualVolumeThreshold == null) || (this.AnnualVolumeThreshold?.Equals(other.AnnualVolumeThreshold) == true)) &&
                ((this.LifeTimeVolume == null && other.LifeTimeVolume == null) || (this.LifeTimeVolume?.Equals(other.LifeTimeVolume) == true)) &&
                ((this.LifeTimeVolumeAccumulated == null && other.LifeTimeVolumeAccumulated == null) || (this.LifeTimeVolumeAccumulated?.Equals(other.LifeTimeVolumeAccumulated) == true)) &&
                ((this.LifeTimeVolumeBalance == null && other.LifeTimeVolumeBalance == null) || (this.LifeTimeVolumeBalance?.Equals(other.LifeTimeVolumeBalance) == true)) &&
                ((this.LifeTimeVolumeOverride == null && other.LifeTimeVolumeOverride == null) || (this.LifeTimeVolumeOverride?.Equals(other.LifeTimeVolumeOverride) == true)) &&
                ((this.LifeTimeVolumeThreshold == null && other.LifeTimeVolumeThreshold == null) || (this.LifeTimeVolumeThreshold?.Equals(other.LifeTimeVolumeThreshold) == true)) &&
                ((this.DailyTransactionCount == null && other.DailyTransactionCount == null) || (this.DailyTransactionCount?.Equals(other.DailyTransactionCount) == true)) &&
                ((this.DailyTransactionAccumulated == null && other.DailyTransactionAccumulated == null) || (this.DailyTransactionAccumulated?.Equals(other.DailyTransactionAccumulated) == true)) &&
                ((this.DailyTransactionBalance == null && other.DailyTransactionBalance == null) || (this.DailyTransactionBalance?.Equals(other.DailyTransactionBalance) == true)) &&
                ((this.DailyTransactionOverride == null && other.DailyTransactionOverride == null) || (this.DailyTransactionOverride?.Equals(other.DailyTransactionOverride) == true)) &&
                ((this.DailyTransactionThreshold == null && other.DailyTransactionThreshold == null) || (this.DailyTransactionThreshold?.Equals(other.DailyTransactionThreshold) == true)) &&
                ((this.WeeklyTransactionCount == null && other.WeeklyTransactionCount == null) || (this.WeeklyTransactionCount?.Equals(other.WeeklyTransactionCount) == true)) &&
                ((this.WeeklyTransactionAccumulated == null && other.WeeklyTransactionAccumulated == null) || (this.WeeklyTransactionAccumulated?.Equals(other.WeeklyTransactionAccumulated) == true)) &&
                ((this.WeeklyTransactionBalance == null && other.WeeklyTransactionBalance == null) || (this.WeeklyTransactionBalance?.Equals(other.WeeklyTransactionBalance) == true)) &&
                ((this.WeeklyTransactionOverride == null && other.WeeklyTransactionOverride == null) || (this.WeeklyTransactionOverride?.Equals(other.WeeklyTransactionOverride) == true)) &&
                ((this.WeeklyTransactionThreshold == null && other.WeeklyTransactionThreshold == null) || (this.WeeklyTransactionThreshold?.Equals(other.WeeklyTransactionThreshold) == true)) &&
                ((this.MonthlyTransactionCount == null && other.MonthlyTransactionCount == null) || (this.MonthlyTransactionCount?.Equals(other.MonthlyTransactionCount) == true)) &&
                ((this.MonthlyTransactionAccumulated == null && other.MonthlyTransactionAccumulated == null) || (this.MonthlyTransactionAccumulated?.Equals(other.MonthlyTransactionAccumulated) == true)) &&
                ((this.MonthlyTransactionBalance == null && other.MonthlyTransactionBalance == null) || (this.MonthlyTransactionBalance?.Equals(other.MonthlyTransactionBalance) == true)) &&
                ((this.MonthlyTransactionOverride == null && other.MonthlyTransactionOverride == null) || (this.MonthlyTransactionOverride?.Equals(other.MonthlyTransactionOverride) == true)) &&
                ((this.MonthlyTransactionThreshold == null && other.MonthlyTransactionThreshold == null) || (this.MonthlyTransactionThreshold?.Equals(other.MonthlyTransactionThreshold) == true)) &&
                ((this.AnnualTransactionCount == null && other.AnnualTransactionCount == null) || (this.AnnualTransactionCount?.Equals(other.AnnualTransactionCount) == true)) &&
                ((this.AnnualTransactionAccumulated == null && other.AnnualTransactionAccumulated == null) || (this.AnnualTransactionAccumulated?.Equals(other.AnnualTransactionAccumulated) == true)) &&
                ((this.AnnualTransactionBalance == null && other.AnnualTransactionBalance == null) || (this.AnnualTransactionBalance?.Equals(other.AnnualTransactionBalance) == true)) &&
                ((this.AnnualTransactionOverride == null && other.AnnualTransactionOverride == null) || (this.AnnualTransactionOverride?.Equals(other.AnnualTransactionOverride) == true)) &&
                ((this.AnnualTransactionThreshold == null && other.AnnualTransactionThreshold == null) || (this.AnnualTransactionThreshold?.Equals(other.AnnualTransactionThreshold) == true)) &&
                ((this.LifeTimeTransactionCount == null && other.LifeTimeTransactionCount == null) || (this.LifeTimeTransactionCount?.Equals(other.LifeTimeTransactionCount) == true)) &&
                ((this.LifeTimeTransactionAccumulated == null && other.LifeTimeTransactionAccumulated == null) || (this.LifeTimeTransactionAccumulated?.Equals(other.LifeTimeTransactionAccumulated) == true)) &&
                ((this.LifeTimeTransactionBalance == null && other.LifeTimeTransactionBalance == null) || (this.LifeTimeTransactionBalance?.Equals(other.LifeTimeTransactionBalance) == true)) &&
                ((this.LifeTimeTransactionOverride == null && other.LifeTimeTransactionOverride == null) || (this.LifeTimeTransactionOverride?.Equals(other.LifeTimeTransactionOverride) == true)) &&
                ((this.LifeTimeTransactionThreshold == null && other.LifeTimeTransactionThreshold == null) || (this.LifeTimeTransactionThreshold?.Equals(other.LifeTimeTransactionThreshold) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Level = {(this.Level == null ? "null" : this.Level)}");
            toStringOutput.Add($"this.DailySpend = {(this.DailySpend == null ? "null" : this.DailySpend.ToString())}");
            toStringOutput.Add($"this.DailySpendAccumulated = {(this.DailySpendAccumulated == null ? "null" : this.DailySpendAccumulated.ToString())}");
            toStringOutput.Add($"this.DailySpendBalance = {(this.DailySpendBalance == null ? "null" : this.DailySpendBalance.ToString())}");
            toStringOutput.Add($"this.DailySpendOverride = {(this.DailySpendOverride == null ? "null" : this.DailySpendOverride.ToString())}");
            toStringOutput.Add($"this.DailySpendThreshold = {(this.DailySpendThreshold == null ? "null" : this.DailySpendThreshold.ToString())}");
            toStringOutput.Add($"this.WeeklySpend = {(this.WeeklySpend == null ? "null" : this.WeeklySpend.ToString())}");
            toStringOutput.Add($"this.WeeklySpendAccumulated = {(this.WeeklySpendAccumulated == null ? "null" : this.WeeklySpendAccumulated.ToString())}");
            toStringOutput.Add($"this.WeeklySpendBalance = {(this.WeeklySpendBalance == null ? "null" : this.WeeklySpendBalance.ToString())}");
            toStringOutput.Add($"this.WeeklySpendOverride = {(this.WeeklySpendOverride == null ? "null" : this.WeeklySpendOverride.ToString())}");
            toStringOutput.Add($"this.WeeklySpendThreshold = {(this.WeeklySpendThreshold == null ? "null" : this.WeeklySpendThreshold.ToString())}");
            toStringOutput.Add($"this.MonthlySpend = {(this.MonthlySpend == null ? "null" : this.MonthlySpend.ToString())}");
            toStringOutput.Add($"this.MonthlySpendAccumulated = {(this.MonthlySpendAccumulated == null ? "null" : this.MonthlySpendAccumulated.ToString())}");
            toStringOutput.Add($"this.MonthlySpendBalance = {(this.MonthlySpendBalance == null ? "null" : this.MonthlySpendBalance.ToString())}");
            toStringOutput.Add($"this.MonthlySpendOverride = {(this.MonthlySpendOverride == null ? "null" : this.MonthlySpendOverride.ToString())}");
            toStringOutput.Add($"this.PerTransactionSpend = {(this.PerTransactionSpend == null ? "null" : this.PerTransactionSpend.ToString())}");
            toStringOutput.Add($"this.PerTransactionSpendOverride = {(this.PerTransactionSpendOverride == null ? "null" : this.PerTransactionSpendOverride.ToString())}");
            toStringOutput.Add($"this.AnnualSpend = {(this.AnnualSpend == null ? "null" : this.AnnualSpend.ToString())}");
            toStringOutput.Add($"this.AnnualSpendAccumulated = {(this.AnnualSpendAccumulated == null ? "null" : this.AnnualSpendAccumulated.ToString())}");
            toStringOutput.Add($"this.AnnualSpendBalance = {(this.AnnualSpendBalance == null ? "null" : this.AnnualSpendBalance.ToString())}");
            toStringOutput.Add($"this.AnnualSpendOverride = {(this.AnnualSpendOverride == null ? "null" : this.AnnualSpendOverride.ToString())}");
            toStringOutput.Add($"this.AnnualSpendThreshold = {(this.AnnualSpendThreshold == null ? "null" : this.AnnualSpendThreshold.ToString())}");
            toStringOutput.Add($"this.LifeTimeSpend = {(this.LifeTimeSpend == null ? "null" : this.LifeTimeSpend.ToString())}");
            toStringOutput.Add($"this.LifeTimeSpendAccumulated = {(this.LifeTimeSpendAccumulated == null ? "null" : this.LifeTimeSpendAccumulated.ToString())}");
            toStringOutput.Add($"this.LifeTimeSpendBalance = {(this.LifeTimeSpendBalance == null ? "null" : this.LifeTimeSpendBalance.ToString())}");
            toStringOutput.Add($"this.LifeTimeSpendOverride = {(this.LifeTimeSpendOverride == null ? "null" : this.LifeTimeSpendOverride.ToString())}");
            toStringOutput.Add($"this.LifeTimeSpendThreshold = {(this.LifeTimeSpendThreshold == null ? "null" : this.LifeTimeSpendThreshold.ToString())}");
            toStringOutput.Add($"this.DailyVolume = {(this.DailyVolume == null ? "null" : this.DailyVolume.ToString())}");
            toStringOutput.Add($"this.DailyVolumeAccumulated = {(this.DailyVolumeAccumulated == null ? "null" : this.DailyVolumeAccumulated.ToString())}");
            toStringOutput.Add($"this.DailyVolumeBalance = {(this.DailyVolumeBalance == null ? "null" : this.DailyVolumeBalance.ToString())}");
            toStringOutput.Add($"this.DailyVolumeOverride = {(this.DailyVolumeOverride == null ? "null" : this.DailyVolumeOverride.ToString())}");
            toStringOutput.Add($"this.DailyVolumeThreshold = {(this.DailyVolumeThreshold == null ? "null" : this.DailyVolumeThreshold.ToString())}");
            toStringOutput.Add($"this.WeeklyVolume = {(this.WeeklyVolume == null ? "null" : this.WeeklyVolume.ToString())}");
            toStringOutput.Add($"this.WeeklyVolumeAccumulated = {(this.WeeklyVolumeAccumulated == null ? "null" : this.WeeklyVolumeAccumulated.ToString())}");
            toStringOutput.Add($"this.WeeklyVolumeBalance = {(this.WeeklyVolumeBalance == null ? "null" : this.WeeklyVolumeBalance.ToString())}");
            toStringOutput.Add($"this.WeeklyVolumeOverride = {(this.WeeklyVolumeOverride == null ? "null" : this.WeeklyVolumeOverride.ToString())}");
            toStringOutput.Add($"this.WeeklyVolumeThreshold = {(this.WeeklyVolumeThreshold == null ? "null" : this.WeeklyVolumeThreshold.ToString())}");
            toStringOutput.Add($"this.MonthlyVolume = {(this.MonthlyVolume == null ? "null" : this.MonthlyVolume.ToString())}");
            toStringOutput.Add($"this.MonthlyVolumeAccumulated = {(this.MonthlyVolumeAccumulated == null ? "null" : this.MonthlyVolumeAccumulated.ToString())}");
            toStringOutput.Add($"this.MonthlyVolumeBalance = {(this.MonthlyVolumeBalance == null ? "null" : this.MonthlyVolumeBalance.ToString())}");
            toStringOutput.Add($"this.MonthlyVolumeOverride = {(this.MonthlyVolumeOverride == null ? "null" : this.MonthlyVolumeOverride.ToString())}");
            toStringOutput.Add($"this.MonthlyVolumeThreshold = {(this.MonthlyVolumeThreshold == null ? "null" : this.MonthlyVolumeThreshold.ToString())}");
            toStringOutput.Add($"this.PerTransactionVolume = {(this.PerTransactionVolume == null ? "null" : this.PerTransactionVolume.ToString())}");
            toStringOutput.Add($"this.PerTransactionVolumeOverride = {(this.PerTransactionVolumeOverride == null ? "null" : this.PerTransactionVolumeOverride.ToString())}");
            toStringOutput.Add($"this.AnnualVolume = {(this.AnnualVolume == null ? "null" : this.AnnualVolume.ToString())}");
            toStringOutput.Add($"this.AnnualVolumeAccumulated = {(this.AnnualVolumeAccumulated == null ? "null" : this.AnnualVolumeAccumulated.ToString())}");
            toStringOutput.Add($"this.AnnualVolumeBalance = {(this.AnnualVolumeBalance == null ? "null" : this.AnnualVolumeBalance.ToString())}");
            toStringOutput.Add($"this.AnnualVolumeOverride = {(this.AnnualVolumeOverride == null ? "null" : this.AnnualVolumeOverride.ToString())}");
            toStringOutput.Add($"this.AnnualVolumeThreshold = {(this.AnnualVolumeThreshold == null ? "null" : this.AnnualVolumeThreshold.ToString())}");
            toStringOutput.Add($"this.LifeTimeVolume = {(this.LifeTimeVolume == null ? "null" : this.LifeTimeVolume.ToString())}");
            toStringOutput.Add($"this.LifeTimeVolumeAccumulated = {(this.LifeTimeVolumeAccumulated == null ? "null" : this.LifeTimeVolumeAccumulated.ToString())}");
            toStringOutput.Add($"this.LifeTimeVolumeBalance = {(this.LifeTimeVolumeBalance == null ? "null" : this.LifeTimeVolumeBalance.ToString())}");
            toStringOutput.Add($"this.LifeTimeVolumeOverride = {(this.LifeTimeVolumeOverride == null ? "null" : this.LifeTimeVolumeOverride.ToString())}");
            toStringOutput.Add($"this.LifeTimeVolumeThreshold = {(this.LifeTimeVolumeThreshold == null ? "null" : this.LifeTimeVolumeThreshold.ToString())}");
            toStringOutput.Add($"this.DailyTransactionCount = {(this.DailyTransactionCount == null ? "null" : this.DailyTransactionCount.ToString())}");
            toStringOutput.Add($"this.DailyTransactionAccumulated = {(this.DailyTransactionAccumulated == null ? "null" : this.DailyTransactionAccumulated.ToString())}");
            toStringOutput.Add($"this.DailyTransactionBalance = {(this.DailyTransactionBalance == null ? "null" : this.DailyTransactionBalance.ToString())}");
            toStringOutput.Add($"this.DailyTransactionOverride = {(this.DailyTransactionOverride == null ? "null" : this.DailyTransactionOverride.ToString())}");
            toStringOutput.Add($"this.DailyTransactionThreshold = {(this.DailyTransactionThreshold == null ? "null" : this.DailyTransactionThreshold.ToString())}");
            toStringOutput.Add($"this.WeeklyTransactionCount = {(this.WeeklyTransactionCount == null ? "null" : this.WeeklyTransactionCount.ToString())}");
            toStringOutput.Add($"this.WeeklyTransactionAccumulated = {(this.WeeklyTransactionAccumulated == null ? "null" : this.WeeklyTransactionAccumulated.ToString())}");
            toStringOutput.Add($"this.WeeklyTransactionBalance = {(this.WeeklyTransactionBalance == null ? "null" : this.WeeklyTransactionBalance.ToString())}");
            toStringOutput.Add($"this.WeeklyTransactionOverride = {(this.WeeklyTransactionOverride == null ? "null" : this.WeeklyTransactionOverride.ToString())}");
            toStringOutput.Add($"this.WeeklyTransactionThreshold = {(this.WeeklyTransactionThreshold == null ? "null" : this.WeeklyTransactionThreshold.ToString())}");
            toStringOutput.Add($"this.MonthlyTransactionCount = {(this.MonthlyTransactionCount == null ? "null" : this.MonthlyTransactionCount.ToString())}");
            toStringOutput.Add($"this.MonthlyTransactionAccumulated = {(this.MonthlyTransactionAccumulated == null ? "null" : this.MonthlyTransactionAccumulated.ToString())}");
            toStringOutput.Add($"this.MonthlyTransactionBalance = {(this.MonthlyTransactionBalance == null ? "null" : this.MonthlyTransactionBalance.ToString())}");
            toStringOutput.Add($"this.MonthlyTransactionOverride = {(this.MonthlyTransactionOverride == null ? "null" : this.MonthlyTransactionOverride.ToString())}");
            toStringOutput.Add($"this.MonthlyTransactionThreshold = {(this.MonthlyTransactionThreshold == null ? "null" : this.MonthlyTransactionThreshold.ToString())}");
            toStringOutput.Add($"this.AnnualTransactionCount = {(this.AnnualTransactionCount == null ? "null" : this.AnnualTransactionCount.ToString())}");
            toStringOutput.Add($"this.AnnualTransactionAccumulated = {(this.AnnualTransactionAccumulated == null ? "null" : this.AnnualTransactionAccumulated.ToString())}");
            toStringOutput.Add($"this.AnnualTransactionBalance = {(this.AnnualTransactionBalance == null ? "null" : this.AnnualTransactionBalance.ToString())}");
            toStringOutput.Add($"this.AnnualTransactionOverride = {(this.AnnualTransactionOverride == null ? "null" : this.AnnualTransactionOverride.ToString())}");
            toStringOutput.Add($"this.AnnualTransactionThreshold = {(this.AnnualTransactionThreshold == null ? "null" : this.AnnualTransactionThreshold.ToString())}");
            toStringOutput.Add($"this.LifeTimeTransactionCount = {(this.LifeTimeTransactionCount == null ? "null" : this.LifeTimeTransactionCount.ToString())}");
            toStringOutput.Add($"this.LifeTimeTransactionAccumulated = {(this.LifeTimeTransactionAccumulated == null ? "null" : this.LifeTimeTransactionAccumulated.ToString())}");
            toStringOutput.Add($"this.LifeTimeTransactionBalance = {(this.LifeTimeTransactionBalance == null ? "null" : this.LifeTimeTransactionBalance.ToString())}");
            toStringOutput.Add($"this.LifeTimeTransactionOverride = {(this.LifeTimeTransactionOverride == null ? "null" : this.LifeTimeTransactionOverride.ToString())}");
            toStringOutput.Add($"this.LifeTimeTransactionThreshold = {(this.LifeTimeTransactionThreshold == null ? "null" : this.LifeTimeTransactionThreshold.ToString())}");
        }
    }
}