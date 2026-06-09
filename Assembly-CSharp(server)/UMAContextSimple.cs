using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UMA;
using UMA.Simple;
using UnityEngine;

// Token: 0x020001A5 RID: 421
[Token(Token = "0x20001A5")]
public class UMAContextSimple : UMAContext
{
	// Token: 0x1700009E RID: 158
	// (get) Token: 0x060008BC RID: 2236 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700009E")]
	public SlotOverlayAssetCache Cache
	{
		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x2605DC4", Offset = "0x2605DC4", VA = "0x7BBCE05DC4")]
		get
		{
			return null;
		}
	}

	// Token: 0x060008BD RID: 2237 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008BD")]
	[Address(RVA = "0x2605DCC", Offset = "0x2605DCC", VA = "0x7BBCE05DCC", Slot = "11")]
	protected virtual void Awake()
	{
	}

	// Token: 0x060008BE RID: 2238 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008BE")]
	[Address(RVA = "0x2605EC4", Offset = "0x2605EC4", VA = "0x7BBCE05EC4", Slot = "4")]
	public override void Start()
	{
	}

	// Token: 0x060008BF RID: 2239 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008BF")]
	[Address(RVA = "0x2605FC4", Offset = "0x2605FC4", VA = "0x7BBCE05FC4", Slot = "5")]
	public override void OnDestroy()
	{
	}

	// Token: 0x060008C0 RID: 2240 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008C0")]
	[Address(RVA = "0x2605DD0", Offset = "0x2605DD0", VA = "0x7BBCE05DD0")]
	private void InitCacheAndManagers()
	{
	}

	// Token: 0x060008C1 RID: 2241 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008C1")]
	[Address(RVA = "0x260608C", Offset = "0x260608C", VA = "0x7BBCE0608C", Slot = "12")]
	public virtual void SetCacheSlotOverlay(bool cache)
	{
	}

	// Token: 0x060008C2 RID: 2242 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008C2")]
	[Address(RVA = "0x2606098", Offset = "0x2606098", VA = "0x7BBCE06098")]
	protected SlotDataAsset GetSlotDataAsset(string name)
	{
		return null;
	}

	// Token: 0x060008C3 RID: 2243 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008C3")]
	[Address(RVA = "0x26060E4", Offset = "0x26060E4", VA = "0x7BBCE060E4")]
	protected SlotDataAsset GetSlotDataAsset(int hash)
	{
		return null;
	}

	// Token: 0x060008C4 RID: 2244 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008C4")]
	[Address(RVA = "0x2606130", Offset = "0x2606130", VA = "0x7BBCE06130")]
	public OverlayDataAsset GetOverlayDataAsset(string name)
	{
		return null;
	}

	// Token: 0x060008C5 RID: 2245 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008C5")]
	[Address(RVA = "0x260617C", Offset = "0x260617C", VA = "0x7BBCE0617C")]
	public OverlayDataAsset GetOverlayDataAsset(int hash)
	{
		return null;
	}

	// Token: 0x060008C6 RID: 2246 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008C6")]
	[Address(RVA = "0x26061C8", Offset = "0x26061C8", VA = "0x7BBCE061C8", Slot = "7")]
	public override SlotData InstantiateSlot(string name)
	{
		return null;
	}

	// Token: 0x060008C7 RID: 2247 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008C7")]
	[Address(RVA = "0x2606284", Offset = "0x2606284", VA = "0x7BBCE06284", Slot = "8")]
	public override SlotData InstantiateSlot(int hash)
	{
		return null;
	}

	// Token: 0x060008C8 RID: 2248 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008C8")]
	[Address(RVA = "0x2606340", Offset = "0x2606340", VA = "0x7BBCE06340", Slot = "9")]
	public override OverlayData InstantiateOverlay(string name)
	{
		return null;
	}

	// Token: 0x060008C9 RID: 2249 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008C9")]
	[Address(RVA = "0x26063FC", Offset = "0x26063FC", VA = "0x7BBCE063FC", Slot = "10")]
	public override OverlayData InstantiateOverlay(int hash)
	{
		return null;
	}

	// Token: 0x060008CA RID: 2250 RVA: 0x00003A98 File Offset: 0x00001C98
	[Token(Token = "0x60008CA")]
	[Address(RVA = "0x26064B8", Offset = "0x26064B8", VA = "0x7BBCE064B8")]
	public bool IsSlotDataAssetCached(string name)
	{
		return default(bool);
	}

	// Token: 0x060008CB RID: 2251 RVA: 0x00003AB0 File Offset: 0x00001CB0
	[Token(Token = "0x60008CB")]
	[Address(RVA = "0x26064F4", Offset = "0x26064F4", VA = "0x7BBCE064F4")]
	public bool IsSlotDataAssetCached(int hash)
	{
		return default(bool);
	}

	// Token: 0x060008CC RID: 2252 RVA: 0x00003AC8 File Offset: 0x00001CC8
	[Token(Token = "0x60008CC")]
	[Address(RVA = "0x2606530", Offset = "0x2606530", VA = "0x7BBCE06530")]
	public bool IsOverlayDataAssetCached(string name)
	{
		return default(bool);
	}

	// Token: 0x060008CD RID: 2253 RVA: 0x00003AE0 File Offset: 0x00001CE0
	[Token(Token = "0x60008CD")]
	[Address(RVA = "0x260656C", Offset = "0x260656C", VA = "0x7BBCE0656C")]
	public bool IsOverlayDataAssetCached(int hash)
	{
		return default(bool);
	}

	// Token: 0x060008CE RID: 2254 RVA: 0x00003AF8 File Offset: 0x00001CF8
	[Token(Token = "0x60008CE")]
	[Address(RVA = "0x26065A8", Offset = "0x26065A8", VA = "0x7BBCE065A8")]
	public bool PreloadSlotDataAsset(string name)
	{
		return default(bool);
	}

	// Token: 0x060008CF RID: 2255 RVA: 0x00003B10 File Offset: 0x00001D10
	[Token(Token = "0x60008CF")]
	[Address(RVA = "0x26065F8", Offset = "0x26065F8", VA = "0x7BBCE065F8")]
	public bool PreloadSlotDataAsset(int hash)
	{
		return default(bool);
	}

	// Token: 0x060008D0 RID: 2256 RVA: 0x00003B28 File Offset: 0x00001D28
	[Token(Token = "0x60008D0")]
	[Address(RVA = "0x2606648", Offset = "0x2606648", VA = "0x7BBCE06648")]
	public bool PreloadOverlayDataAsset(string name)
	{
		return default(bool);
	}

	// Token: 0x060008D1 RID: 2257 RVA: 0x00003B40 File Offset: 0x00001D40
	[Token(Token = "0x60008D1")]
	[Address(RVA = "0x2606698", Offset = "0x2606698", VA = "0x7BBCE06698")]
	public bool PreloadOverlayDataAsset(int hash)
	{
		return default(bool);
	}

	// Token: 0x060008D2 RID: 2258 RVA: 0x00003B58 File Offset: 0x00001D58
	[Token(Token = "0x60008D2")]
	[Address(RVA = "0x26066E8", Offset = "0x26066E8", VA = "0x7BBCE066E8")]
	public bool IsSlotContainsOverlay(string slotName, string overlayName)
	{
		return default(bool);
	}

	// Token: 0x060008D3 RID: 2259 RVA: 0x00003B70 File Offset: 0x00001D70
	[Token(Token = "0x60008D3")]
	[Address(RVA = "0x260673C", Offset = "0x260673C", VA = "0x7BBCE0673C")]
	public bool IsSlotContainsOverlay(int slotHash, int overlayHash)
	{
		return default(bool);
	}

	// Token: 0x060008D4 RID: 2260 RVA: 0x00003B88 File Offset: 0x00001D88
	[Token(Token = "0x60008D4")]
	[Address(RVA = "0x2606790", Offset = "0x2606790", VA = "0x7BBCE06790")]
	public uint LoadSlotOrOverlayDataAsset(string name, bool isSlot, Action<UnityEngine.Object, uint> callback)
	{
		return 0U;
	}

	// Token: 0x060008D5 RID: 2261 RVA: 0x00003BA0 File Offset: 0x00001DA0
	[Token(Token = "0x60008D5")]
	[Address(RVA = "0x26067F4", Offset = "0x26067F4", VA = "0x7BBCE067F4")]
	public uint LoadSlotOrOverlayDataAsset(int hash, bool isSlot, Action<UnityEngine.Object, uint, int> callback, int param)
	{
		return 0U;
	}

	// Token: 0x060008D6 RID: 2262 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008D6")]
	[Address(RVA = "0x2606860", Offset = "0x2606860", VA = "0x7BBCE06860")]
	public void CancelAsyncLoad(ICollection<uint> tickets, bool clear = true)
	{
	}

	// Token: 0x060008D7 RID: 2263 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008D7")]
	[Address(RVA = "0x2606BD0", Offset = "0x2606BD0", VA = "0x7BBCE06BD0")]
	public void CancelAsyncLoad(uint ticket)
	{
	}

	// Token: 0x060008D8 RID: 2264 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008D8")]
	[Address(RVA = "0x2606C1C", Offset = "0x2606C1C", VA = "0x7BBCE06C1C")]
	public UMATextRecipe GetTextRecipe(string name)
	{
		return null;
	}

	// Token: 0x060008D9 RID: 2265 RVA: 0x00003BB8 File Offset: 0x00001DB8
	[Token(Token = "0x60008D9")]
	[Address(RVA = "0x2606D40", Offset = "0x2606D40", VA = "0x7BBCE06D40")]
	public static UmaRecipeSimple GetSimpleRecipe(string name)
	{
		return default(UmaRecipeSimple);
	}

	// Token: 0x060008DA RID: 2266 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008DA")]
	[Address(RVA = "0x2605DBC", Offset = "0x2605DBC", VA = "0x7BBCE05DBC")]
	public UMAContextSimple()
	{
	}

	// Token: 0x0400089E RID: 2206
	[Token(Token = "0x400089E")]
	[FieldOffset(Offset = "0x38")]
	public bool CacheSlotOverlay;

	// Token: 0x0400089F RID: 2207
	[Token(Token = "0x400089F")]
	[FieldOffset(Offset = "0x40")]
	protected SlotOverlayAssetCache m_Cache;

	// Token: 0x040008A0 RID: 2208
	[Token(Token = "0x40008A0")]
	[FieldOffset(Offset = "0x48")]
	private bool m_AsyncLoadAllCancled;
}
