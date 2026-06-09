using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UMA;
using UnityEngine;

// Token: 0x020001A6 RID: 422
[Token(Token = "0x20001A6")]
public class OverlayLibrary : OverlayLibraryBase
{
	// Token: 0x060008DB RID: 2267 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008DB")]
	[Address(RVA = "0x22AA83C", Offset = "0x22AA83C", VA = "0x7BBCAAA83C")]
	private void Awake()
	{
	}

	// Token: 0x060008DC RID: 2268 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008DC")]
	[Address(RVA = "0x22AA848", Offset = "0x22AA848", VA = "0x7BBCAAA848", Slot = "10")]
	public override void UpdateDictionary()
	{
	}

	// Token: 0x060008DD RID: 2269 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008DD")]
	[Address(RVA = "0x22AAA44", Offset = "0x22AAA44", VA = "0x7BBCAAAA44", Slot = "4")]
	public override void AddOverlayAsset(OverlayDataAsset overlay)
	{
	}

	// Token: 0x060008DE RID: 2270 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008DE")]
	[Address(RVA = "0x22AAD58", Offset = "0x22AAD58", VA = "0x7BBCAAAD58", Slot = "11")]
	public override void ValidateDictionary()
	{
	}

	// Token: 0x060008DF RID: 2271 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008DF")]
	[Address(RVA = "0x22AADE0", Offset = "0x22AADE0", VA = "0x7BBCAAADE0", Slot = "5")]
	public override OverlayData InstantiateOverlay(string name)
	{
		return null;
	}

	// Token: 0x060008E0 RID: 2272 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008E0")]
	[Address(RVA = "0x22AAF78", Offset = "0x22AAF78", VA = "0x7BBCAAAF78", Slot = "6")]
	public override OverlayData InstantiateOverlay(int nameHash)
	{
		return null;
	}

	// Token: 0x060008E1 RID: 2273 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008E1")]
	[Address(RVA = "0x22AB060", Offset = "0x22AB060", VA = "0x7BBCAAB060", Slot = "7")]
	public override OverlayData InstantiateOverlay(string name, Color color)
	{
		return null;
	}

	// Token: 0x060008E2 RID: 2274 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008E2")]
	[Address(RVA = "0x22AB198", Offset = "0x22AB198", VA = "0x7BBCAAB198", Slot = "8")]
	public override OverlayData InstantiateOverlay(int nameHash, Color color)
	{
		return null;
	}

	// Token: 0x060008E3 RID: 2275 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008E3")]
	[Address(RVA = "0x22AAEB8", Offset = "0x22AAEB8", VA = "0x7BBCAAAEB8")]
	private OverlayData Internal_InstantiateOverlay(int nameHash)
	{
		return null;
	}

	// Token: 0x060008E4 RID: 2276 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008E4")]
	[Address(RVA = "0x22AB2E0", Offset = "0x22AB2E0", VA = "0x7BBCAAB2E0", Slot = "9")]
	public override OverlayDataAsset[] GetAllOverlayAssets()
	{
		return null;
	}

	// Token: 0x060008E5 RID: 2277 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E5")]
	[Address(RVA = "0x22AB2E8", Offset = "0x22AB2E8", VA = "0x7BBCAAB2E8")]
	public OverlayLibrary()
	{
	}

	// Token: 0x040008A1 RID: 2209
	[Token(Token = "0x40008A1")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected OverlayDataAsset[] overlayElementList;

	// Token: 0x040008A2 RID: 2210
	[Token(Token = "0x40008A2")]
	[FieldOffset(Offset = "0x20")]
	[NonSerialized]
	private Dictionary<int, OverlayDataAsset> overlayDictionary;

	// Token: 0x040008A3 RID: 2211
	[Token(Token = "0x40008A3")]
	[FieldOffset(Offset = "0x28")]
	public int scaleAdjust;

	// Token: 0x040008A4 RID: 2212
	[Token(Token = "0x40008A4")]
	[FieldOffset(Offset = "0x2C")]
	public bool readWrite;

	// Token: 0x040008A5 RID: 2213
	[Token(Token = "0x40008A5")]
	[FieldOffset(Offset = "0x2D")]
	public bool compress;
}
