using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UMA;
using UnityEngine;

// Token: 0x020001B4 RID: 436
[Token(Token = "0x20001B4")]
public abstract class SlotLibraryBase : MonoBehaviour
{
	// Token: 0x06000931 RID: 2353 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000931")]
	[Address(RVA = "0x225FB7C", Offset = "0x225FB7C", VA = "0x7BBCA5FB7C", Slot = "4")]
	public virtual void AddSlotAsset(SlotDataAsset slot)
	{
	}

	// Token: 0x06000932 RID: 2354 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000932")]
	[Address(RVA = "0x225FBE4", Offset = "0x225FBE4", VA = "0x7BBCA5FBE4", Slot = "5")]
	public virtual SlotDataAsset[] GetAllSlotAssets()
	{
		return null;
	}

	// Token: 0x06000933 RID: 2355
	[Token(Token = "0x6000933")]
	public abstract SlotData InstantiateSlot(string name);

	// Token: 0x06000934 RID: 2356
	[Token(Token = "0x6000934")]
	public abstract SlotData InstantiateSlot(int nameHash);

	// Token: 0x06000935 RID: 2357
	[Token(Token = "0x6000935")]
	public abstract SlotData InstantiateSlot(string name, List<OverlayData> overlayList);

	// Token: 0x06000936 RID: 2358
	[Token(Token = "0x6000936")]
	public abstract SlotData InstantiateSlot(int nameHash, List<OverlayData> overlayList);

	// Token: 0x06000937 RID: 2359 RVA: 0x00003C90 File Offset: 0x00001E90
	[Token(Token = "0x6000937")]
	[Address(RVA = "0x225FC4C", Offset = "0x225FC4C", VA = "0x7BBCA5FC4C", Slot = "10")]
	public virtual bool HasSlot(string name)
	{
		return default(bool);
	}

	// Token: 0x06000938 RID: 2360 RVA: 0x00003CA8 File Offset: 0x00001EA8
	[Token(Token = "0x6000938")]
	[Address(RVA = "0x225FCB4", Offset = "0x225FCB4", VA = "0x7BBCA5FCB4", Slot = "11")]
	public virtual bool HasSlot(int nameHash)
	{
		return default(bool);
	}

	// Token: 0x06000939 RID: 2361 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000939")]
	[Address(RVA = "0x225FD1C", Offset = "0x225FD1C", VA = "0x7BBCA5FD1C", Slot = "12")]
	public virtual SlotDataAsset GetSlotDataAsset(string name)
	{
		return null;
	}

	// Token: 0x0600093A RID: 2362
	[Token(Token = "0x600093A")]
	public abstract void UpdateDictionary();

	// Token: 0x0600093B RID: 2363
	[Token(Token = "0x600093B")]
	public abstract void ValidateDictionary();

	// Token: 0x0600093C RID: 2364 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600093C")]
	[Address(RVA = "0x225FB74", Offset = "0x225FB74", VA = "0x7BBCA5FB74")]
	protected SlotLibraryBase()
	{
	}
}
