using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001BA RID: 442
[Token(Token = "0x20001BA")]
public static class UMAFacade
{
	// Token: 0x0600094A RID: 2378 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600094A")]
	[Address(RVA = "0x2607028", Offset = "0x2607028", VA = "0x7BBCE07028")]
	public static void SetImpl(IUMAInterface impl)
	{
	}

	// Token: 0x0600094B RID: 2379 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600094B")]
	[Address(RVA = "0x25F6AC4", Offset = "0x25F6AC4", VA = "0x7BBCDF6AC4")]
	public static GameObject GetAssetIndexResource()
	{
		return null;
	}

	// Token: 0x0600094C RID: 2380 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600094C")]
	[Address(RVA = "0x26070B4", Offset = "0x26070B4", VA = "0x7BBCE070B4")]
	public static Type GetDynamicAssetLoaderType()
	{
		return null;
	}

	// Token: 0x040008D2 RID: 2258
	[Token(Token = "0x40008D2")]
	[FieldOffset(Offset = "0x0")]
	private static IUMAInterface m_Impl;
}
