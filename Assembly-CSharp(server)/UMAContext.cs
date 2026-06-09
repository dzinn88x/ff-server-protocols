using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UMA;
using UMACharacterSystem;
using UnityEngine;

// Token: 0x020001B2 RID: 434
[Token(Token = "0x20001B2")]
public class UMAContext : MonoBehaviour
{
	// Token: 0x06000919 RID: 2329 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000919")]
	[Address(RVA = "0x2605774", Offset = "0x2605774", VA = "0x7BBCE05774", Slot = "4")]
	public virtual void Start()
	{
	}

	// Token: 0x0600091A RID: 2330 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600091A")]
	[Address(RVA = "0x2605904", Offset = "0x2605904", VA = "0x7BBCE05904", Slot = "5")]
	public virtual void OnDestroy()
	{
	}

	// Token: 0x0600091B RID: 2331 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600091B")]
	[Address(RVA = "0x26059A0", Offset = "0x26059A0", VA = "0x7BBCE059A0")]
	public void ValidateDictionaries()
	{
	}

	// Token: 0x0600091C RID: 2332 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600091C")]
	[Address(RVA = "0x2605A1C", Offset = "0x2605A1C", VA = "0x7BBCE05A1C", Slot = "6")]
	public virtual RaceData GetRace(string name)
	{
		return null;
	}

	// Token: 0x0600091D RID: 2333 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600091D")]
	[Address(RVA = "0x2605A58", Offset = "0x2605A58", VA = "0x7BBCE05A58")]
	public RaceData GetRace(int nameHash)
	{
		return null;
	}

	// Token: 0x0600091E RID: 2334 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600091E")]
	[Address(RVA = "0x2605A94", Offset = "0x2605A94", VA = "0x7BBCE05A94", Slot = "7")]
	public virtual SlotData InstantiateSlot(string name)
	{
		return null;
	}

	// Token: 0x0600091F RID: 2335 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600091F")]
	[Address(RVA = "0x2605AD0", Offset = "0x2605AD0", VA = "0x7BBCE05AD0", Slot = "8")]
	public virtual SlotData InstantiateSlot(int nameHash)
	{
		return null;
	}

	// Token: 0x06000920 RID: 2336 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000920")]
	[Address(RVA = "0x2605B0C", Offset = "0x2605B0C", VA = "0x7BBCE05B0C")]
	public SlotData InstantiateSlot(string name, List<OverlayData> overlayList)
	{
		return null;
	}

	// Token: 0x06000921 RID: 2337 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000921")]
	[Address(RVA = "0x2605B58", Offset = "0x2605B58", VA = "0x7BBCE05B58")]
	public SlotData InstantiateSlot(int nameHash, List<OverlayData> overlayList)
	{
		return null;
	}

	// Token: 0x06000922 RID: 2338 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000922")]
	[Address(RVA = "0x2605BA4", Offset = "0x2605BA4", VA = "0x7BBCE05BA4", Slot = "9")]
	public virtual OverlayData InstantiateOverlay(string name)
	{
		return null;
	}

	// Token: 0x06000923 RID: 2339 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000923")]
	[Address(RVA = "0x2605BE0", Offset = "0x2605BE0", VA = "0x7BBCE05BE0", Slot = "10")]
	public virtual OverlayData InstantiateOverlay(int nameHash)
	{
		return null;
	}

	// Token: 0x06000924 RID: 2340 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000924")]
	[Address(RVA = "0x2605C1C", Offset = "0x2605C1C", VA = "0x7BBCE05C1C")]
	public OverlayData InstantiateOverlay(string name, Color color)
	{
		return null;
	}

	// Token: 0x06000925 RID: 2341 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000925")]
	[Address(RVA = "0x2605C88", Offset = "0x2605C88", VA = "0x7BBCE05C88")]
	public OverlayData InstantiateOverlay(int nameHash, Color color)
	{
		return null;
	}

	// Token: 0x06000926 RID: 2342 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000926")]
	[Address(RVA = "0x2601BC0", Offset = "0x2601BC0", VA = "0x7BBCE01BC0")]
	public static UMAContext FindInstance()
	{
		return null;
	}

	// Token: 0x06000927 RID: 2343 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000927")]
	[Address(RVA = "0x2605CF4", Offset = "0x2605CF4", VA = "0x7BBCE05CF4")]
	public UMAContext()
	{
	}

	// Token: 0x040008CB RID: 2251
	[Token(Token = "0x40008CB")]
	[FieldOffset(Offset = "0x18")]
	public DynamicCharacterSystemBase dynamicCharacterSystem;

	// Token: 0x040008CC RID: 2252
	[Token(Token = "0x40008CC")]
	[FieldOffset(Offset = "0x0")]
	public static UMAContext Instance;

	// Token: 0x040008CD RID: 2253
	[Token(Token = "0x40008CD")]
	[FieldOffset(Offset = "0x20")]
	public RaceLibraryBase raceLibrary;

	// Token: 0x040008CE RID: 2254
	[Token(Token = "0x40008CE")]
	[FieldOffset(Offset = "0x28")]
	public SlotLibraryBase slotLibrary;

	// Token: 0x040008CF RID: 2255
	[Token(Token = "0x40008CF")]
	[FieldOffset(Offset = "0x30")]
	public OverlayLibraryBase overlayLibrary;
}
