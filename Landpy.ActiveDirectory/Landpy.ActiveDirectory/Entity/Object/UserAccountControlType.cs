﻿using System;

namespace Landpy.ActiveDirectory.Entity.Object
{
    [Flags]
    public enum UserAccountControlType
    {
        Unknow = 0,
        Script = 1,
        AccountDisabled = 2,
        HomeDirectoryRequired = 8,
        AccountLockedOut_DEPRECATED = 16,
        PasswordNotRequired = 32,
        PasswordCannotChange_DEPRECATED = 64,
        EncryptedTextPasswordAllowed = 128,
        TempDuplicateAccount = 256,
        NormalAccount = 512,
        InterDomainTrustAccount = 2048,
        WorkstationTrustAccount = 4096,
        ServerTrustAccount = 8192,
        PasswordDoesNotExpire = 65536,
        MnsLogonAccount = 131072,
        SmartCardRequired = 262144,
        TrustedForDelegation = 524288,
        AccountNotDelegated = 1048576,
        UseDesKeyOnly = 2097152,
        DontRequirePreauth = 4194304,
        PasswordExpired_DEPRECATED = 8388608,
        TrustedToAuthenticateForDelegation = 16777216,
        NoAuthDataRequired = 33554432
    }
}