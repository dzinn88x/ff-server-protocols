using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UMA;
using UnityEngine;

// Token: 0x020001A7 RID: 423
[Token(Token = "0x20001A7")]
public class RaceLibrary : RaceLibraryBase
{
	// Token: 0x060008E6 RID: 2278 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E6")]
	[Address(RVA = "0x23DC704", Offset = "0x23DC704", VA = "0x7BBCBDC704")]
	private void Awake()
	{
	}

	// Token: 0x060008E7 RID: 2279 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E7")]
	[Address(RVA = "0x23DC710", Offset = "0x23DC710", VA = "0x7BBCBDC710", Slot = "9")]
	public override void ValidateDictionary()
	{
	}

	// Token: 0x060008E8 RID: 2280 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E8")]
	[Address(RVA = "0x23DC798", Offset = "0x23DC798", VA = "0x7BBCBDC798", Slot = "8")]
	public override void UpdateDictionary()
	{
	}

	// Token: 0x060008E9 RID: 2281 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E9")]
	[Address(RVA = "0x23DC9C8", Offset = "0x23DC9C8", VA = "0x7BBCBDC9C8", Slot = "4")]
	public override void AddRace(RaceData race)
	{
	}

	// Token: 0x060008EA RID: 2282 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008EA")]
	[Address(RVA = "0x23DCC6C", Offset = "0x23DCC6C", VA = "0x7BBCBDCC6C", Slot = "5")]
	public override RaceData GetRace(string raceName)
	{
		return null;
	}

	// Token: 0x060008EB RID: 2283 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008EB")]
	[Address(RVA = "0x23DCD20", Offset = "0x23DCD20", VA = "0x7BBCBDCD20", Slot = "6")]
	public override RaceData GetRace(int raceHash)
	{
		return null;
	}

	// Token: 0x060008EC RID: 2284 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008EC")]
	[Address(RVA = "0x23DCEC0", Offset = "0x23DCEC0", VA = "0x7BBCBDCEC0", Slot = "7")]
	public override RaceData[] GetAllRaces()
	{
		return null;
	}

	// Token: 0x060008ED RID: 2285 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008ED")]
	[Address(RVA = "0x23DCEC8", Offset = "0x23DCEC8", VA = "0x7BBCBDCEC8")]
	public RaceLibrary()
	{
	}

	// Token: 0x040008A6 RID: 2214
	[Token(Token = "0x40008A6")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected RaceData[] raceElementList;

	// Token: 0x040008A7 RID: 2215
	[Token(Token = "0x40008A7")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<string, RaceData> raceDictionary;
}
