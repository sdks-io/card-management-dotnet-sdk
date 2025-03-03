// <copyright file="UsageRestrictionsCard.cs" company="APIMatic">
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
    /// UsageRestrictionsCard.
    /// </summary>
    public class UsageRestrictionsCard
    {
        private double? dailySpend;
        private double? weeklySpend;
        private double? monthlySpend;
        private double? perTransactionSpend;
        private double? annualSpend;
        private double? lifeTimeSpend;
        private double? dailyVolume;
        private double? weeklyVolume;
        private double? monthlyVolume;
        private double? annualVolume;
        private double? dailyTransactionCount;
        private double? weeklyTransactionCount;
        private double? monthlyTransactionCount;
        private double? annualTransactionCount;
        private double? lifeTimeTransactionCount;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "DailySpend", false },
            { "WeeklySpend", false },
            { "MonthlySpend", false },
            { "PerTransactionSpend", false },
            { "AnnualSpend", false },
            { "LifeTimeSpend", false },
            { "DailyVolume", false },
            { "WeeklyVolume", false },
            { "MonthlyVolume", false },
            { "AnnualVolume", false },
            { "DailyTransactionCount", false },
            { "WeeklyTransactionCount", false },
            { "MonthlyTransactionCount", false },
            { "AnnualTransactionCount", false },
            { "LifeTimeTransactionCount", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageRestrictionsCard"/> class.
        /// </summary>
        public UsageRestrictionsCard()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageRestrictionsCard"/> class.
        /// </summary>
        /// <param name="dailySpend">DailySpend.</param>
        /// <param name="weeklySpend">WeeklySpend.</param>
        /// <param name="monthlySpend">MonthlySpend.</param>
        /// <param name="perTransactionSpend">PerTransactionSpend.</param>
        /// <param name="annualSpend">AnnualSpend.</param>
        /// <param name="lifeTimeSpend">LifeTimeSpend.</param>
        /// <param name="dailyVolume">DailyVolume.</param>
        /// <param name="weeklyVolume">WeeklyVolume.</param>
        /// <param name="monthlyVolume">MonthlyVolume.</param>
        /// <param name="perTransactionVolume">PerTransactionVolume.</param>
        /// <param name="annualVolume">AnnualVolume.</param>
        /// <param name="lifeTimeVolume">LifeTimeVolume.</param>
        /// <param name="dailyTransactionCount">DailyTransactionCount.</param>
        /// <param name="weeklyTransactionCount">WeeklyTransactionCount.</param>
        /// <param name="monthlyTransactionCount">MonthlyTransactionCount.</param>
        /// <param name="annualTransactionCount">AnnualTransactionCount.</param>
        /// <param name="lifeTimeTransactionCount">LifeTimeTransactionCount.</param>
        public UsageRestrictionsCard(
            double? dailySpend = null,
            double? weeklySpend = null,
            double? monthlySpend = null,
            double? perTransactionSpend = null,
            double? annualSpend = null,
            double? lifeTimeSpend = null,
            double? dailyVolume = null,
            double? weeklyVolume = null,
            double? monthlyVolume = null,
            double? perTransactionVolume = null,
            double? annualVolume = null,
            double? lifeTimeVolume = null,
            double? dailyTransactionCount = null,
            double? weeklyTransactionCount = null,
            double? monthlyTransactionCount = null,
            double? annualTransactionCount = null,
            double? lifeTimeTransactionCount = null)
        {

            if (dailySpend != null)
            {
                this.DailySpend = dailySpend;
            }

            if (weeklySpend != null)
            {
                this.WeeklySpend = weeklySpend;
            }

            if (monthlySpend != null)
            {
                this.MonthlySpend = monthlySpend;
            }

            if (perTransactionSpend != null)
            {
                this.PerTransactionSpend = perTransactionSpend;
            }

            if (annualSpend != null)
            {
                this.AnnualSpend = annualSpend;
            }

            if (lifeTimeSpend != null)
            {
                this.LifeTimeSpend = lifeTimeSpend;
            }

            if (dailyVolume != null)
            {
                this.DailyVolume = dailyVolume;
            }

            if (weeklyVolume != null)
            {
                this.WeeklyVolume = weeklyVolume;
            }

            if (monthlyVolume != null)
            {
                this.MonthlyVolume = monthlyVolume;
            }
            this.PerTransactionVolume = perTransactionVolume;

            if (annualVolume != null)
            {
                this.AnnualVolume = annualVolume;
            }
            this.LifeTimeVolume = lifeTimeVolume;

            if (dailyTransactionCount != null)
            {
                this.DailyTransactionCount = dailyTransactionCount;
            }

            if (weeklyTransactionCount != null)
            {
                this.WeeklyTransactionCount = weeklyTransactionCount;
            }

            if (monthlyTransactionCount != null)
            {
                this.MonthlyTransactionCount = monthlyTransactionCount;
            }

            if (annualTransactionCount != null)
            {
                this.AnnualTransactionCount = annualTransactionCount;
            }

            if (lifeTimeTransactionCount != null)
            {
                this.LifeTimeTransactionCount = lifeTimeTransactionCount;
            }
        }

        /// <summary>
        /// Maximum spend value (amount) allowed per day.
        /// Optional
        /// It allows null in the input field. If Values is passed as null, apply the card type limit. However, if the card type limit is NULL for the same field then No limit will be applied in Gateway.
        /// </summary>
        [JsonProperty("DailySpend")]
        public double? DailySpend
        {
            get
            {
                return this.dailySpend;
            }

            set
            {
                this.shouldSerialize["DailySpend"] = true;
                this.dailySpend = value;
            }
        }

        /// <summary>
        /// Maximum spend value (amount) allowed per week.
        /// Optional
        /// </summary>
        [JsonProperty("WeeklySpend")]
        public double? WeeklySpend
        {
            get
            {
                return this.weeklySpend;
            }

            set
            {
                this.shouldSerialize["WeeklySpend"] = true;
                this.weeklySpend = value;
            }
        }

        /// <summary>
        /// Maximum spend value (amount) allowed per month.
        /// Optional
        /// </summary>
        [JsonProperty("MonthlySpend")]
        public double? MonthlySpend
        {
            get
            {
                return this.monthlySpend;
            }

            set
            {
                this.shouldSerialize["MonthlySpend"] = true;
                this.monthlySpend = value;
            }
        }

        /// <summary>
        /// Maximum spend value (amount) allowed per transaction.
        /// Optional
        /// </summary>
        [JsonProperty("PerTransactionSpend")]
        public double? PerTransactionSpend
        {
            get
            {
                return this.perTransactionSpend;
            }

            set
            {
                this.shouldSerialize["PerTransactionSpend"] = true;
                this.perTransactionSpend = value;
            }
        }

        /// <summary>
        /// Maximum spend value (amount) allowed per annum.
        /// Optional
        /// </summary>
        [JsonProperty("AnnualSpend")]
        public double? AnnualSpend
        {
            get
            {
                return this.annualSpend;
            }

            set
            {
                this.shouldSerialize["AnnualSpend"] = true;
                this.annualSpend = value;
            }
        }

        /// <summary>
        /// Maximum spend value (amount) allowed in card’s life time.
        /// Optional
        /// </summary>
        [JsonProperty("LifeTimeSpend")]
        public double? LifeTimeSpend
        {
            get
            {
                return this.lifeTimeSpend;
            }

            set
            {
                this.shouldSerialize["LifeTimeSpend"] = true;
                this.lifeTimeSpend = value;
            }
        }

        /// <summary>
        /// Maximum volume (quantity) allowed per day.
        /// Optional
        /// </summary>
        [JsonProperty("DailyVolume")]
        public double? DailyVolume
        {
            get
            {
                return this.dailyVolume;
            }

            set
            {
                this.shouldSerialize["DailyVolume"] = true;
                this.dailyVolume = value;
            }
        }

        /// <summary>
        /// Maximum volume (quantity) allowed per week.
        /// Optional
        /// </summary>
        [JsonProperty("WeeklyVolume")]
        public double? WeeklyVolume
        {
            get
            {
                return this.weeklyVolume;
            }

            set
            {
                this.shouldSerialize["WeeklyVolume"] = true;
                this.weeklyVolume = value;
            }
        }

        /// <summary>
        /// Maximum volume (quantity) allowed per month.
        /// Optional
        /// </summary>
        [JsonProperty("MonthlyVolume")]
        public double? MonthlyVolume
        {
            get
            {
                return this.monthlyVolume;
            }

            set
            {
                this.shouldSerialize["MonthlyVolume"] = true;
                this.monthlyVolume = value;
            }
        }

        /// <summary>
        /// Maximum volume (quantity) allowed per transaction.
        /// Optional
        /// </summary>
        [JsonProperty("PerTransactionVolume", NullValueHandling = NullValueHandling.Ignore)]
        public double? PerTransactionVolume { get; set; }

        /// <summary>
        /// Maximum volume (quantity) allowed per annum.
        /// Optional
        /// </summary>
        [JsonProperty("AnnualVolume")]
        public double? AnnualVolume
        {
            get
            {
                return this.annualVolume;
            }

            set
            {
                this.shouldSerialize["AnnualVolume"] = true;
                this.annualVolume = value;
            }
        }

        /// <summary>
        /// Maximum volume (quantity) allowed in card’s life time.
        /// Optional
        /// </summary>
        [JsonProperty("LifeTimeVolume", NullValueHandling = NullValueHandling.Ignore)]
        public double? LifeTimeVolume { get; set; }

        /// <summary>
        /// Maximum number of transactions allowed per day.
        /// Optional
        /// </summary>
        [JsonProperty("DailyTransactionCount")]
        public double? DailyTransactionCount
        {
            get
            {
                return this.dailyTransactionCount;
            }

            set
            {
                this.shouldSerialize["DailyTransactionCount"] = true;
                this.dailyTransactionCount = value;
            }
        }

        /// <summary>
        /// Maximum number of transactions allowed per week.
        /// Optional
        /// </summary>
        [JsonProperty("WeeklyTransactionCount")]
        public double? WeeklyTransactionCount
        {
            get
            {
                return this.weeklyTransactionCount;
            }

            set
            {
                this.shouldSerialize["WeeklyTransactionCount"] = true;
                this.weeklyTransactionCount = value;
            }
        }

        /// <summary>
        /// Maximum number of transactions allowed per month.
        /// Optional.
        /// </summary>
        [JsonProperty("MonthlyTransactionCount")]
        public double? MonthlyTransactionCount
        {
            get
            {
                return this.monthlyTransactionCount;
            }

            set
            {
                this.shouldSerialize["MonthlyTransactionCount"] = true;
                this.monthlyTransactionCount = value;
            }
        }

        /// <summary>
        /// Maximum number of transactions allowed per annum.
        /// </summary>
        [JsonProperty("AnnualTransactionCount")]
        public double? AnnualTransactionCount
        {
            get
            {
                return this.annualTransactionCount;
            }

            set
            {
                this.shouldSerialize["AnnualTransactionCount"] = true;
                this.annualTransactionCount = value;
            }
        }

        /// <summary>
        /// Maximum number of transactions allowed in card’s lifetime.
        /// Optional
        /// </summary>
        [JsonProperty("LifeTimeTransactionCount")]
        public double? LifeTimeTransactionCount
        {
            get
            {
                return this.lifeTimeTransactionCount;
            }

            set
            {
                this.shouldSerialize["LifeTimeTransactionCount"] = true;
                this.lifeTimeTransactionCount = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UsageRestrictionsCard : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDailySpend()
        {
            this.shouldSerialize["DailySpend"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetWeeklySpend()
        {
            this.shouldSerialize["WeeklySpend"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMonthlySpend()
        {
            this.shouldSerialize["MonthlySpend"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPerTransactionSpend()
        {
            this.shouldSerialize["PerTransactionSpend"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAnnualSpend()
        {
            this.shouldSerialize["AnnualSpend"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetLifeTimeSpend()
        {
            this.shouldSerialize["LifeTimeSpend"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDailyVolume()
        {
            this.shouldSerialize["DailyVolume"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetWeeklyVolume()
        {
            this.shouldSerialize["WeeklyVolume"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMonthlyVolume()
        {
            this.shouldSerialize["MonthlyVolume"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAnnualVolume()
        {
            this.shouldSerialize["AnnualVolume"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDailyTransactionCount()
        {
            this.shouldSerialize["DailyTransactionCount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetWeeklyTransactionCount()
        {
            this.shouldSerialize["WeeklyTransactionCount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMonthlyTransactionCount()
        {
            this.shouldSerialize["MonthlyTransactionCount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAnnualTransactionCount()
        {
            this.shouldSerialize["AnnualTransactionCount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetLifeTimeTransactionCount()
        {
            this.shouldSerialize["LifeTimeTransactionCount"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDailySpend()
        {
            return this.shouldSerialize["DailySpend"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeWeeklySpend()
        {
            return this.shouldSerialize["WeeklySpend"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMonthlySpend()
        {
            return this.shouldSerialize["MonthlySpend"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePerTransactionSpend()
        {
            return this.shouldSerialize["PerTransactionSpend"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAnnualSpend()
        {
            return this.shouldSerialize["AnnualSpend"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLifeTimeSpend()
        {
            return this.shouldSerialize["LifeTimeSpend"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDailyVolume()
        {
            return this.shouldSerialize["DailyVolume"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeWeeklyVolume()
        {
            return this.shouldSerialize["WeeklyVolume"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMonthlyVolume()
        {
            return this.shouldSerialize["MonthlyVolume"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAnnualVolume()
        {
            return this.shouldSerialize["AnnualVolume"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDailyTransactionCount()
        {
            return this.shouldSerialize["DailyTransactionCount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeWeeklyTransactionCount()
        {
            return this.shouldSerialize["WeeklyTransactionCount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMonthlyTransactionCount()
        {
            return this.shouldSerialize["MonthlyTransactionCount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAnnualTransactionCount()
        {
            return this.shouldSerialize["AnnualTransactionCount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLifeTimeTransactionCount()
        {
            return this.shouldSerialize["LifeTimeTransactionCount"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UsageRestrictionsCard other &&
                (this.DailySpend == null && other.DailySpend == null ||
                 this.DailySpend?.Equals(other.DailySpend) == true) &&
                (this.WeeklySpend == null && other.WeeklySpend == null ||
                 this.WeeklySpend?.Equals(other.WeeklySpend) == true) &&
                (this.MonthlySpend == null && other.MonthlySpend == null ||
                 this.MonthlySpend?.Equals(other.MonthlySpend) == true) &&
                (this.PerTransactionSpend == null && other.PerTransactionSpend == null ||
                 this.PerTransactionSpend?.Equals(other.PerTransactionSpend) == true) &&
                (this.AnnualSpend == null && other.AnnualSpend == null ||
                 this.AnnualSpend?.Equals(other.AnnualSpend) == true) &&
                (this.LifeTimeSpend == null && other.LifeTimeSpend == null ||
                 this.LifeTimeSpend?.Equals(other.LifeTimeSpend) == true) &&
                (this.DailyVolume == null && other.DailyVolume == null ||
                 this.DailyVolume?.Equals(other.DailyVolume) == true) &&
                (this.WeeklyVolume == null && other.WeeklyVolume == null ||
                 this.WeeklyVolume?.Equals(other.WeeklyVolume) == true) &&
                (this.MonthlyVolume == null && other.MonthlyVolume == null ||
                 this.MonthlyVolume?.Equals(other.MonthlyVolume) == true) &&
                (this.PerTransactionVolume == null && other.PerTransactionVolume == null ||
                 this.PerTransactionVolume?.Equals(other.PerTransactionVolume) == true) &&
                (this.AnnualVolume == null && other.AnnualVolume == null ||
                 this.AnnualVolume?.Equals(other.AnnualVolume) == true) &&
                (this.LifeTimeVolume == null && other.LifeTimeVolume == null ||
                 this.LifeTimeVolume?.Equals(other.LifeTimeVolume) == true) &&
                (this.DailyTransactionCount == null && other.DailyTransactionCount == null ||
                 this.DailyTransactionCount?.Equals(other.DailyTransactionCount) == true) &&
                (this.WeeklyTransactionCount == null && other.WeeklyTransactionCount == null ||
                 this.WeeklyTransactionCount?.Equals(other.WeeklyTransactionCount) == true) &&
                (this.MonthlyTransactionCount == null && other.MonthlyTransactionCount == null ||
                 this.MonthlyTransactionCount?.Equals(other.MonthlyTransactionCount) == true) &&
                (this.AnnualTransactionCount == null && other.AnnualTransactionCount == null ||
                 this.AnnualTransactionCount?.Equals(other.AnnualTransactionCount) == true) &&
                (this.LifeTimeTransactionCount == null && other.LifeTimeTransactionCount == null ||
                 this.LifeTimeTransactionCount?.Equals(other.LifeTimeTransactionCount) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"DailySpend = {(this.DailySpend == null ? "null" : this.DailySpend.ToString())}");
            toStringOutput.Add($"WeeklySpend = {(this.WeeklySpend == null ? "null" : this.WeeklySpend.ToString())}");
            toStringOutput.Add($"MonthlySpend = {(this.MonthlySpend == null ? "null" : this.MonthlySpend.ToString())}");
            toStringOutput.Add($"PerTransactionSpend = {(this.PerTransactionSpend == null ? "null" : this.PerTransactionSpend.ToString())}");
            toStringOutput.Add($"AnnualSpend = {(this.AnnualSpend == null ? "null" : this.AnnualSpend.ToString())}");
            toStringOutput.Add($"LifeTimeSpend = {(this.LifeTimeSpend == null ? "null" : this.LifeTimeSpend.ToString())}");
            toStringOutput.Add($"DailyVolume = {(this.DailyVolume == null ? "null" : this.DailyVolume.ToString())}");
            toStringOutput.Add($"WeeklyVolume = {(this.WeeklyVolume == null ? "null" : this.WeeklyVolume.ToString())}");
            toStringOutput.Add($"MonthlyVolume = {(this.MonthlyVolume == null ? "null" : this.MonthlyVolume.ToString())}");
            toStringOutput.Add($"PerTransactionVolume = {(this.PerTransactionVolume == null ? "null" : this.PerTransactionVolume.ToString())}");
            toStringOutput.Add($"AnnualVolume = {(this.AnnualVolume == null ? "null" : this.AnnualVolume.ToString())}");
            toStringOutput.Add($"LifeTimeVolume = {(this.LifeTimeVolume == null ? "null" : this.LifeTimeVolume.ToString())}");
            toStringOutput.Add($"DailyTransactionCount = {(this.DailyTransactionCount == null ? "null" : this.DailyTransactionCount.ToString())}");
            toStringOutput.Add($"WeeklyTransactionCount = {(this.WeeklyTransactionCount == null ? "null" : this.WeeklyTransactionCount.ToString())}");
            toStringOutput.Add($"MonthlyTransactionCount = {(this.MonthlyTransactionCount == null ? "null" : this.MonthlyTransactionCount.ToString())}");
            toStringOutput.Add($"AnnualTransactionCount = {(this.AnnualTransactionCount == null ? "null" : this.AnnualTransactionCount.ToString())}");
            toStringOutput.Add($"LifeTimeTransactionCount = {(this.LifeTimeTransactionCount == null ? "null" : this.LifeTimeTransactionCount.ToString())}");
        }
    }
}