using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UMA;
using UnityEngine;

// Token: 0x02000192 RID: 402
[Token(Token = "0x2000192")]
public class DynamicOverlayLibrary : OverlayLibrary
{
	// Token: 0x0600083A RID: 2106 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600083A")]
	[Address(RVA = "0x23F186C", Offset = "0x23F186C", VA = "0x7BBCBF186C")]
	public void Start()
	{
	}

	// Token: 0x0600083B RID: 2107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600083B")]
	[Address(RVA = "0x23F18E4", Offset = "0x23F18E4", VA = "0x7BBCBF18E4")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600083C RID: 2108 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600083C")]
	[Address(RVA = "0x23F18E8", Offset = "0x23F18E8", VA = "0x7BBCBF18E8")]
	public void ClearEditorAddedAssets()
	{
	}

	// Token: 0x0600083D RID: 2109 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600083D")]
	[Address(RVA = "0x23F18EC", Offset = "0x23F18EC", VA = "0x7BBCBF18EC")]
	public void UpdateDynamicOverlayLibrary([Optional] int? nameHash)
	{
	}

	// Token: 0x0600083E RID: 2110 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600083E")]
	[Address(RVA = "0x23F1A34", Offset = "0x23F1A34", VA = "0x7BBCBF1A34")]
	public void UpdateDynamicOverlayLibrary(string overlayName)
	{
	}

	// Token: 0x0600083F RID: 2111 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600083F")]
	[Address(RVA = "0x23F1B70", Offset = "0x23F1B70", VA = "0x7BBCBF1B70")]
	private void AddOverlayAssets(OverlayDataAsset[] overlays)
	{
	}

	// Token: 0x06000840 RID: 2112 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000840")]
	[Address(RVA = "0x23F1BF0", Offset = "0x23F1BF0", VA = "0x7BBCBF1BF0", Slot = "5")]
	public override OverlayData InstantiateOverlay(string name)
	{
		return null;
	}

	// Token: 0x06000841 RID: 2113 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000841")]
	[Address(RVA = "0x23F1DDC", Offset = "0x23F1DDC", VA = "0x7BBCBF1DDC", Slot = "6")]
	public override OverlayData InstantiateOverlay(int nameHash)
	{
		return null;
	}

	// Token: 0x06000842 RID: 2114 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000842")]
	[Address(RVA = "0x23F203C", Offset = "0x23F203C", VA = "0x7BBCBF203C", Slot = "7")]
	public override OverlayData InstantiateOverlay(string name, Color color)
	{
		return null;
	}

	// Token: 0x06000843 RID: 2115 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000843")]
	[Address(RVA = "0x23F2280", Offset = "0x23F2280", VA = "0x7BBCBF2280", Slot = "8")]
	public override OverlayData InstantiateOverlay(int nameHash, Color color)
	{
		return null;
	}

	// Token: 0x06000844 RID: 2116 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000844")]
	[Address(RVA = "0x23F2538", Offset = "0x23F2538", VA = "0x7BBCBF2538")]
	public string GetOriginatingAssetBundle(string overlayName)
	{
		return null;
	}

	// Token: 0x06000845 RID: 2117 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000845")]
	[Address(RVA = "0x23F2790", Offset = "0x23F2790", VA = "0x7BBCBF2790")]
	public DynamicOverlayLibrary()
	{
	}

	// Token: 0x04000849 RID: 2121
	[Token(Token = "0x4000849")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
	public bool dynamicallyAddFromResources;

	// Token: 0x0400084A RID: 2122
	[Token(Token = "0x400084A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x1100798", Offset = "0x1100798")]
	public string resourcesFolderPath;

	// Token: 0x0400084B RID: 2123
	[Token(Token = "0x400084B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool dynamicallyAddFromAssetBundles;

	// Token: 0x0400084C RID: 2124
	[Token(Token = "0x400084C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x11007D0", Offset = "0x11007D0")]
	public string assetBundleNamesToSearch;

	// Token: 0x0400084D RID: 2125
	[Token(Token = "0x400084D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Dictionary<string, List<string>> assetBundlesUsedDict;

	// Token: 0x0400084E RID: 2126
	[Token(Token = "0x400084E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[HideInInspector]
	[NonSerialized]
	public bool downloadAssetsEnabled;
}
