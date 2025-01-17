﻿// Decompiled with JetBrains decompiler
// Type: UnityEditor.iOS.Xcode.ICloudEntitlements
// Assembly: UnityEditor.iOS.Extensions.Xcode, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 36E9AB58-F6A7-4B4D-BAB5-BE8059694DCD
// Assembly location: D:\workspace\pk\trunk\usdk\publish\ios\tools\UnityEditor.iOS.Extensions.Xcode.dll

namespace UnityEditor.iOS.Xcode
{
  internal class ICloudEntitlements
  {
    internal static readonly string ContainerIdKey = "com.apple.developer.icloud-container-identifiers";
    internal static readonly string ContainerIdValue = "iCloud.$(CFBundleIdentifier)";
    internal static readonly string UbiquityContainerIdKey = "com.apple.developer.ubiquity-container-identifiers";
    internal static readonly string UbiquityContainerIdValue = "iCloud.$(CFBundleIdentifier)";
    internal static readonly string ServicesKey = "com.apple.developer.icloud-services";
    internal static readonly string ServicesDocValue = "CloudDocuments";
    internal static readonly string ServicesKitValue = "CloudKit";
    internal static readonly string KeyValueStoreKey = "com.apple.developer.ubiquity-kvstore-identifier";
    internal static readonly string KeyValueStoreValue = "$(TeamIdentifierPrefix)$(CFBundleIdentifier)";
  }
}
