// <copyright file="CardUsageRestrictions.cs" company="APIMatic">
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
    /// CardUsageRestrictions.
    /// </summary>
    public class CardUsageRestrictions
    {
        private string level;
        private double? dailySpendLimit;
        private double? weeklySpendLimit;
        private double? monthlySpendLimit;
        private double? annualSpendLimit;
        private double? lifeTimeSpendLimit;
        private double? dailyVolumeLimit;
        private double? weeklyVolumeLimit;
        private double? monthlyVolumeLimit;
        private double? annualVolumeLimit;
        private double? lifeTimeVolumeLimit;
        private double? transactionSpendLimit;
        private double? transactionVolumeLimit;
        private double? dailyTransactionCount;
        private double? weeklyTransactionCount;
        private double? monthlyTransactionCount;
        private double? annualTransactionCount;
        private double? lifeTimeTransactionCount;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "Level", false },
            { "DailySpendLimit", false },
            { "WeeklySpendLimit", false },
            { "MonthlySpendLimit", false },
            { "AnnualSpendLimit", false },
            { "LifeTimeSpendLimit", false },
            { "DailyVolumeLimit", false },
            { "WeeklyVolumeLimit", false },
            { "MonthlyVolumeLimit", false },
            { "AnnualVolumeLimit", true },
            { "LifeTimeVolumeLimit", false },
            { "TransactionSpendLimit", false },
            { "TransactionVolumeLimit", false },
            { "DailyTransactionCount", false },
            { "WeeklyTransactionCount", false },
            { "MonthlyTransactionCount", false },
            { "AnnualTransactionCount", false },
            { "LifeTimeTransactionCount", false },
        };

        private Dictionary<string, bool> hasPropertySetterCalledFor = new Dictionary<string, bool>
        {
            { "AnnualVolumeLimit", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CardUsageRestrictions"/> class.
        /// </summary>
        public CardUsageRestrictions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardUsageRestrictions"/> class.
        /// </summary>
        /// <param name="level">Level.</param>
        /// <param name="dailySpendLimit">DailySpendLimit.</param>
        /// <param name="weeklySpendLimit">WeeklySpendLimit.</param>
        /// <param name="monthlySpendLimit">MonthlySpendLimit.</param>
        /// <param name="annualSpendLimit">AnnualSpendLimit.</param>
        /// <param name="lifeTimeSpendLimit">LifeTimeSpendLimit.</param>
        /// <param name="dailyVolumeLimit">DailyVolumeLimit.</param>
        /// <param name="weeklyVolumeLimit">WeeklyVolumeLimit.</param>
        /// <param name="monthlyVolumeLimit">MonthlyVolumeLimit.</param>
        /// <param name="annualVolumeLimit">AnnualVolumeLimit.</param>
        /// <param name="lifeTimeVolumeLimit">LifeTimeVolumeLimit.</param>
        /// <param name="transactionSpendLimit">TransactionSpendLimit.</param>
        /// <param name="transactionVolumeLimit">TransactionVolumeLimit.</param>
        /// <param name="dailyTransactionCount">DailyTransactionCount.</param>
        /// <param name="weeklyTransactionCount">WeeklyTransactionCount.</param>
        /// <param name="monthlyTransactionCount">MonthlyTransactionCount.</param>
        /// <param name="annualTransactionCount">AnnualTransactionCount.</param>
        /// <param name="lifeTimeTransactionCount">LifeTimeTransactionCount.</param>
        /// <param name="isVelocityCeiling">IsVelocityCeiling.</param>
        public CardUsageRestrictions(
            string level = null,
            double? dailySpendLimit = null,
            double? weeklySpendLimit = null,
            double? monthlySpendLimit = null,
            double? annualSpendLimit = null,
            double? lifeTimeSpendLimit = null,
            double? dailyVolumeLimit = null,
            double? weeklyVolumeLimit = null,
            double? monthlyVolumeLimit = null,
            double? annualVolumeLimit = 0,
            double? lifeTimeVolumeLimit = null,
            double? transactionSpendLimit = null,
            double? transactionVolumeLimit = null,
            double? dailyTransactionCount = null,
            double? weeklyTransactionCount = null,
            double? monthlyTransactionCount = null,
            double? annualTransactionCount = null,
            double? lifeTimeTransactionCount = null,
            bool? isVelocityCeiling = null)
        {

            if (level != null)
            {
                this.Level = level;
            }

            if (dailySpendLimit != null)
            {
                this.DailySpendLimit = dailySpendLimit;
            }

            if (weeklySpendLimit != null)
            {
                this.WeeklySpendLimit = weeklySpendLimit;
            }

            if (monthlySpendLimit != null)
            {
                this.MonthlySpendLimit = monthlySpendLimit;
            }

            if (annualSpendLimit != null)
            {
                this.AnnualSpendLimit = annualSpendLimit;
            }

            if (lifeTimeSpendLimit != null)
            {
                this.LifeTimeSpendLimit = lifeTimeSpendLimit;
            }

            if (dailyVolumeLimit != null)
            {
                this.DailyVolumeLimit = dailyVolumeLimit;
            }

            if (weeklyVolumeLimit != null)
            {
                this.WeeklyVolumeLimit = weeklyVolumeLimit;
            }

            if (monthlyVolumeLimit != null)
            {
                this.MonthlyVolumeLimit = monthlyVolumeLimit;
            }
            this.AnnualVolumeLimit = annualVolumeLimit;

            if (lifeTimeVolumeLimit != null)
            {
                this.LifeTimeVolumeLimit = lifeTimeVolumeLimit;
            }

            if (transactionSpendLimit != null)
            {
                this.TransactionSpendLimit = transactionSpendLimit;
            }

            if (transactionVolumeLimit != null)
            {
                this.TransactionVolumeLimit = transactionVolumeLimit;
            }

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
            this.IsVelocityCeiling = isVelocityCeiling;
        }

        /// <summary>
        /// Describes at which level the restriction is set at.
        /// Possible values:
        /// OU = Restriction set at ColCo card type
        /// Customer = Restriction set at customer card type
        /// </summary>
        [JsonProperty("Level")]
        public string Level
        {
            get
            {
                return this.level;
            }

            set
            {
                this.shouldSerialize["Level"] = true;
                this.level = value;
            }
        }

        /// <summary>
        /// Maximum amount that can be spend on the card in a day.
        /// </summary>
        [JsonProperty("DailySpendLimit")]
        public double? DailySpendLimit
        {
            get
            {
                return this.dailySpendLimit;
            }

            set
            {
                this.shouldSerialize["DailySpendLimit"] = true;
                this.dailySpendLimit = value;
            }
        }

        /// <summary>
        /// Maximum amount that can be spend on the card in a week.
        /// </summary>
        [JsonProperty("WeeklySpendLimit")]
        public double? WeeklySpendLimit
        {
            get
            {
                return this.weeklySpendLimit;
            }

            set
            {
                this.shouldSerialize["WeeklySpendLimit"] = true;
                this.weeklySpendLimit = value;
            }
        }

        /// <summary>
        /// Maximum amount that can be spend on the card in a month.
        /// </summary>
        [JsonProperty("MonthlySpendLimit")]
        public double? MonthlySpendLimit
        {
            get
            {
                return this.monthlySpendLimit;
            }

            set
            {
                this.shouldSerialize["MonthlySpendLimit"] = true;
                this.monthlySpendLimit = value;
            }
        }

        /// <summary>
        /// Maximum amount that can be spend on the card in a year.
        /// </summary>
        [JsonProperty("AnnualSpendLimit")]
        public double? AnnualSpendLimit
        {
            get
            {
                return this.annualSpendLimit;
            }

            set
            {
                this.shouldSerialize["AnnualSpendLimit"] = true;
                this.annualSpendLimit = value;
            }
        }

        /// <summary>
        /// Maximum amount that can be spend on the card in the card’s life time.
        /// </summary>
        [JsonProperty("LifeTimeSpendLimit")]
        public double? LifeTimeSpendLimit
        {
            get
            {
                return this.lifeTimeSpendLimit;
            }

            set
            {
                this.shouldSerialize["LifeTimeSpendLimit"] = true;
                this.lifeTimeSpendLimit = value;
            }
        }

        /// <summary>
        /// Maximum volume of fuel that can be bought on the card in a day.
        /// </summary>
        [JsonProperty("DailyVolumeLimit")]
        public double? DailyVolumeLimit
        {
            get
            {
                return this.dailyVolumeLimit;
            }

            set
            {
                this.shouldSerialize["DailyVolumeLimit"] = true;
                this.dailyVolumeLimit = value;
            }
        }

        /// <summary>
        /// Maximum volume of fuel that can be bought on the card in a week.
        /// </summary>
        [JsonProperty("WeeklyVolumeLimit")]
        public double? WeeklyVolumeLimit
        {
            get
            {
                return this.weeklyVolumeLimit;
            }

            set
            {
                this.shouldSerialize["WeeklyVolumeLimit"] = true;
                this.weeklyVolumeLimit = value;
            }
        }

        /// <summary>
        /// Maximum volume of fuel that can be bought on the card in a month.
        /// </summary>
        [JsonProperty("MonthlyVolumeLimit")]
        public double? MonthlyVolumeLimit
        {
            get
            {
                return this.monthlyVolumeLimit;
            }

            set
            {
                this.shouldSerialize["MonthlyVolumeLimit"] = true;
                this.monthlyVolumeLimit = value;
            }
        }

        /// <summary>
        /// Maximum volume of fuel that can be bought on the card in a year.
        /// </summary>
        [JsonProperty("AnnualVolumeLimit")]
        public double? AnnualVolumeLimit
        {
            get
            {
                if (!hasPropertySetterCalledFor["AnnualVolumeLimit"] &&
                    annualVolumeLimit == null)
                {
                    return 0; // Default value
                }

                return this.annualVolumeLimit;
            }

            set
            {
                this.shouldSerialize["AnnualVolumeLimit"] = true;
                hasPropertySetterCalledFor["AnnualVolumeLimit"] = true;
                this.annualVolumeLimit = value;
            }
        }

        /// <summary>
        /// Maximum volume of fuel that can be bought on the card in the card’s life time.
        /// </summary>
        [JsonProperty("LifeTimeVolumeLimit")]
        public double? LifeTimeVolumeLimit
        {
            get
            {
                return this.lifeTimeVolumeLimit;
            }

            set
            {
                this.shouldSerialize["LifeTimeVolumeLimit"] = true;
                this.lifeTimeVolumeLimit = value;
            }
        }

        /// <summary>
        /// Maximum amount that can be spend on the card in a transaction.
        /// </summary>
        [JsonProperty("TransactionSpendLimit")]
        public double? TransactionSpendLimit
        {
            get
            {
                return this.transactionSpendLimit;
            }

            set
            {
                this.shouldSerialize["TransactionSpendLimit"] = true;
                this.transactionSpendLimit = value;
            }
        }

        /// <summary>
        /// Maximum volume of fuel that can be bought on the card in a transaction.
        /// </summary>
        [JsonProperty("TransactionVolumeLimit")]
        public double? TransactionVolumeLimit
        {
            get
            {
                return this.transactionVolumeLimit;
            }

            set
            {
                this.shouldSerialize["TransactionVolumeLimit"] = true;
                this.transactionVolumeLimit = value;
            }
        }

        /// <summary>
        /// Maximum number of transactions allowed on a card in a day.
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
        /// Maximum number of transactions allowed on a card in a week.
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
        /// Maximum number of transactions allowed on a card in a month.
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
        /// Maximum number of transactions allowed on the card in a year.
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
        /// Maximum number of transactions allowed on the card in the card’s life time.
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

        /// <summary>
        /// IsVelocityCeiling flag
        /// Note: When "True", the velocity defaults configured in MS DB will be considered as the Max Limits for velocity changes. When ‘false’ max allowed limits will be 999999999999 for Type “Count” and 9999999999.99 for Type ‘Value’.
        /// </summary>
        [JsonProperty("IsVelocityCeiling", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsVelocityCeiling { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CardUsageRestrictions : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetLevel()
        {
            this.shouldSerialize["Level"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDailySpendLimit()
        {
            this.shouldSerialize["DailySpendLimit"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetWeeklySpendLimit()
        {
            this.shouldSerialize["WeeklySpendLimit"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMonthlySpendLimit()
        {
            this.shouldSerialize["MonthlySpendLimit"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAnnualSpendLimit()
        {
            this.shouldSerialize["AnnualSpendLimit"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetLifeTimeSpendLimit()
        {
            this.shouldSerialize["LifeTimeSpendLimit"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDailyVolumeLimit()
        {
            this.shouldSerialize["DailyVolumeLimit"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetWeeklyVolumeLimit()
        {
            this.shouldSerialize["WeeklyVolumeLimit"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMonthlyVolumeLimit()
        {
            this.shouldSerialize["MonthlyVolumeLimit"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAnnualVolumeLimit()
        {
            this.shouldSerialize["AnnualVolumeLimit"] = false;
            this.hasPropertySetterCalledFor["AnnualVolumeLimit"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetLifeTimeVolumeLimit()
        {
            this.shouldSerialize["LifeTimeVolumeLimit"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTransactionSpendLimit()
        {
            this.shouldSerialize["TransactionSpendLimit"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTransactionVolumeLimit()
        {
            this.shouldSerialize["TransactionVolumeLimit"] = false;
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
        public bool ShouldSerializeLevel()
        {
            return this.shouldSerialize["Level"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDailySpendLimit()
        {
            return this.shouldSerialize["DailySpendLimit"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeWeeklySpendLimit()
        {
            return this.shouldSerialize["WeeklySpendLimit"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMonthlySpendLimit()
        {
            return this.shouldSerialize["MonthlySpendLimit"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAnnualSpendLimit()
        {
            return this.shouldSerialize["AnnualSpendLimit"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLifeTimeSpendLimit()
        {
            return this.shouldSerialize["LifeTimeSpendLimit"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDailyVolumeLimit()
        {
            return this.shouldSerialize["DailyVolumeLimit"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeWeeklyVolumeLimit()
        {
            return this.shouldSerialize["WeeklyVolumeLimit"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMonthlyVolumeLimit()
        {
            return this.shouldSerialize["MonthlyVolumeLimit"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAnnualVolumeLimit()
        {
            return this.shouldSerialize["AnnualVolumeLimit"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLifeTimeVolumeLimit()
        {
            return this.shouldSerialize["LifeTimeVolumeLimit"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTransactionSpendLimit()
        {
            return this.shouldSerialize["TransactionSpendLimit"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTransactionVolumeLimit()
        {
            return this.shouldSerialize["TransactionVolumeLimit"];
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

            return obj is CardUsageRestrictions other &&
                (this.Level == null && other.Level == null ||
                 this.Level?.Equals(other.Level) == true) &&
                (this.DailySpendLimit == null && other.DailySpendLimit == null ||
                 this.DailySpendLimit?.Equals(other.DailySpendLimit) == true) &&
                (this.WeeklySpendLimit == null && other.WeeklySpendLimit == null ||
                 this.WeeklySpendLimit?.Equals(other.WeeklySpendLimit) == true) &&
                (this.MonthlySpendLimit == null && other.MonthlySpendLimit == null ||
                 this.MonthlySpendLimit?.Equals(other.MonthlySpendLimit) == true) &&
                (this.AnnualSpendLimit == null && other.AnnualSpendLimit == null ||
                 this.AnnualSpendLimit?.Equals(other.AnnualSpendLimit) == true) &&
                (this.LifeTimeSpendLimit == null && other.LifeTimeSpendLimit == null ||
                 this.LifeTimeSpendLimit?.Equals(other.LifeTimeSpendLimit) == true) &&
                (this.DailyVolumeLimit == null && other.DailyVolumeLimit == null ||
                 this.DailyVolumeLimit?.Equals(other.DailyVolumeLimit) == true) &&
                (this.WeeklyVolumeLimit == null && other.WeeklyVolumeLimit == null ||
                 this.WeeklyVolumeLimit?.Equals(other.WeeklyVolumeLimit) == true) &&
                (this.MonthlyVolumeLimit == null && other.MonthlyVolumeLimit == null ||
                 this.MonthlyVolumeLimit?.Equals(other.MonthlyVolumeLimit) == true) &&
                (this.AnnualVolumeLimit == null && other.AnnualVolumeLimit == null ||
                 this.AnnualVolumeLimit?.Equals(other.AnnualVolumeLimit) == true) &&
                (this.LifeTimeVolumeLimit == null && other.LifeTimeVolumeLimit == null ||
                 this.LifeTimeVolumeLimit?.Equals(other.LifeTimeVolumeLimit) == true) &&
                (this.TransactionSpendLimit == null && other.TransactionSpendLimit == null ||
                 this.TransactionSpendLimit?.Equals(other.TransactionSpendLimit) == true) &&
                (this.TransactionVolumeLimit == null && other.TransactionVolumeLimit == null ||
                 this.TransactionVolumeLimit?.Equals(other.TransactionVolumeLimit) == true) &&
                (this.DailyTransactionCount == null && other.DailyTransactionCount == null ||
                 this.DailyTransactionCount?.Equals(other.DailyTransactionCount) == true) &&
                (this.WeeklyTransactionCount == null && other.WeeklyTransactionCount == null ||
                 this.WeeklyTransactionCount?.Equals(other.WeeklyTransactionCount) == true) &&
                (this.MonthlyTransactionCount == null && other.MonthlyTransactionCount == null ||
                 this.MonthlyTransactionCount?.Equals(other.MonthlyTransactionCount) == true) &&
                (this.AnnualTransactionCount == null && other.AnnualTransactionCount == null ||
                 this.AnnualTransactionCount?.Equals(other.AnnualTransactionCount) == true) &&
                (this.LifeTimeTransactionCount == null && other.LifeTimeTransactionCount == null ||
                 this.LifeTimeTransactionCount?.Equals(other.LifeTimeTransactionCount) == true) &&
                (this.IsVelocityCeiling == null && other.IsVelocityCeiling == null ||
                 this.IsVelocityCeiling?.Equals(other.IsVelocityCeiling) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Level = {this.Level ?? "null"}");
            toStringOutput.Add($"DailySpendLimit = {(this.DailySpendLimit == null ? "null" : this.DailySpendLimit.ToString())}");
            toStringOutput.Add($"WeeklySpendLimit = {(this.WeeklySpendLimit == null ? "null" : this.WeeklySpendLimit.ToString())}");
            toStringOutput.Add($"MonthlySpendLimit = {(this.MonthlySpendLimit == null ? "null" : this.MonthlySpendLimit.ToString())}");
            toStringOutput.Add($"AnnualSpendLimit = {(this.AnnualSpendLimit == null ? "null" : this.AnnualSpendLimit.ToString())}");
            toStringOutput.Add($"LifeTimeSpendLimit = {(this.LifeTimeSpendLimit == null ? "null" : this.LifeTimeSpendLimit.ToString())}");
            toStringOutput.Add($"DailyVolumeLimit = {(this.DailyVolumeLimit == null ? "null" : this.DailyVolumeLimit.ToString())}");
            toStringOutput.Add($"WeeklyVolumeLimit = {(this.WeeklyVolumeLimit == null ? "null" : this.WeeklyVolumeLimit.ToString())}");
            toStringOutput.Add($"MonthlyVolumeLimit = {(this.MonthlyVolumeLimit == null ? "null" : this.MonthlyVolumeLimit.ToString())}");
            toStringOutput.Add($"AnnualVolumeLimit = {(this.AnnualVolumeLimit == null ? "null" : this.AnnualVolumeLimit.ToString())}");
            toStringOutput.Add($"LifeTimeVolumeLimit = {(this.LifeTimeVolumeLimit == null ? "null" : this.LifeTimeVolumeLimit.ToString())}");
            toStringOutput.Add($"TransactionSpendLimit = {(this.TransactionSpendLimit == null ? "null" : this.TransactionSpendLimit.ToString())}");
            toStringOutput.Add($"TransactionVolumeLimit = {(this.TransactionVolumeLimit == null ? "null" : this.TransactionVolumeLimit.ToString())}");
            toStringOutput.Add($"DailyTransactionCount = {(this.DailyTransactionCount == null ? "null" : this.DailyTransactionCount.ToString())}");
            toStringOutput.Add($"WeeklyTransactionCount = {(this.WeeklyTransactionCount == null ? "null" : this.WeeklyTransactionCount.ToString())}");
            toStringOutput.Add($"MonthlyTransactionCount = {(this.MonthlyTransactionCount == null ? "null" : this.MonthlyTransactionCount.ToString())}");
            toStringOutput.Add($"AnnualTransactionCount = {(this.AnnualTransactionCount == null ? "null" : this.AnnualTransactionCount.ToString())}");
            toStringOutput.Add($"LifeTimeTransactionCount = {(this.LifeTimeTransactionCount == null ? "null" : this.LifeTimeTransactionCount.ToString())}");
            toStringOutput.Add($"IsVelocityCeiling = {(this.IsVelocityCeiling == null ? "null" : this.IsVelocityCeiling.ToString())}");
        }
    }
}