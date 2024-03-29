﻿//@CodeCopy
//MdStart
#if ACCOUNT_ON && LOGGING_ON
namespace QTProjectTeam.Logic.Models.Logging
{
    using System;
    public partial class ActionLog : ModelObject
    {
        static ActionLog()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        public ActionLog()
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        new internal QTProjectTeam.Logic.Entities.Logging.ActionLog Source
        {
            get => (QTProjectTeam.Logic.Entities.Logging.ActionLog)(_source ??= new QTProjectTeam.Logic.Entities.Logging.ActionLog());
            set => _source = value;
        }
        public IdType IdentityId
        {
            get => Source.IdentityId;
            set => Source.IdentityId = value;
        }
        public System.DateTime Time
        {
            get => Source.Time;
            set => Source.Time = value;
        }
        public System.String Subject
        {
            get => Source.Subject;
            set => Source.Subject = value;
        }
        public System.String Action
        {
            get => Source.Action;
            set => Source.Action = value;
        }
        public System.String Info
        {
            get => Source.Info;
            set => Source.Info = value;
        }
        internal void CopyProperties(QTProjectTeam.Logic.Entities.Logging.ActionLog other)
        {
            bool handled = false;
            BeforeCopyProperties(other, ref handled);
            if (handled == false)
            {
                IdentityId = other.IdentityId;
                Time = other.Time;
                Subject = other.Subject;
                Action = other.Action;
                Info = other.Info;
                Id = other.Id;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(QTProjectTeam.Logic.Entities.Logging.ActionLog other, ref bool handled);
        partial void AfterCopyProperties(QTProjectTeam.Logic.Entities.Logging.ActionLog other);
        public void CopyProperties(QTProjectTeam.Logic.Models.Logging.ActionLog other)
        {
            bool handled = false;
            BeforeCopyProperties(other, ref handled);
            if (handled == false)
            {
                IdentityId = other.IdentityId;
                Time = other.Time;
                Subject = other.Subject;
                Action = other.Action;
                Info = other.Info;
                Id = other.Id;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(QTProjectTeam.Logic.Models.Logging.ActionLog other, ref bool handled);
        partial void AfterCopyProperties(QTProjectTeam.Logic.Models.Logging.ActionLog other);
        public override bool Equals(object? obj)
        {
            bool result = false;
            if (obj is Models.Logging.ActionLog other)
            {
                result = Id == other.Id;
            }
            return result;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(IdentityId, Time, Subject, Action, Info, Id);
        }
        public static QTProjectTeam.Logic.Models.Logging.ActionLog Create()
        {
            BeforeCreate();
            var result = new QTProjectTeam.Logic.Models.Logging.ActionLog();
            AfterCreate(result);
            return result;
        }
        public static QTProjectTeam.Logic.Models.Logging.ActionLog Create(object other)
        {
            BeforeCreate(other);
            CommonBase.Extensions.ObjectExtensions.CheckArgument(other, nameof(other));
            var result = new QTProjectTeam.Logic.Models.Logging.ActionLog();
            CommonBase.Extensions.ObjectExtensions.CopyFrom(result, other);
            AfterCreate(result, other);
            return result;
        }
        public static QTProjectTeam.Logic.Models.Logging.ActionLog Create(QTProjectTeam.Logic.Models.Logging.ActionLog other)
        {
            BeforeCreate(other);
            var result = new QTProjectTeam.Logic.Models.Logging.ActionLog();
            result.CopyProperties(other);
            AfterCreate(result, other);
            return result;
        }
        internal static QTProjectTeam.Logic.Models.Logging.ActionLog Create(QTProjectTeam.Logic.Entities.Logging.ActionLog other)
        {
            BeforeCreate(other);
            var result = new QTProjectTeam.Logic.Models.Logging.ActionLog();
            result.Source = other;
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate();
        static partial void AfterCreate(QTProjectTeam.Logic.Models.Logging.ActionLog instance);
        static partial void BeforeCreate(object other);
        static partial void AfterCreate(QTProjectTeam.Logic.Models.Logging.ActionLog instance, object other);
        static partial void BeforeCreate(QTProjectTeam.Logic.Models.Logging.ActionLog other);
        static partial void AfterCreate(QTProjectTeam.Logic.Models.Logging.ActionLog instance, QTProjectTeam.Logic.Models.Logging.ActionLog other);
        static partial void BeforeCreate(QTProjectTeam.Logic.Entities.Logging.ActionLog other);
        static partial void AfterCreate(QTProjectTeam.Logic.Models.Logging.ActionLog instance, QTProjectTeam.Logic.Entities.Logging.ActionLog other);
    }
}
#endif
//MdEnd
