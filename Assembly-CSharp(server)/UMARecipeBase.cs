using System;
using Il2CppDummyDll;
using UMA;
using UnityEngine;

// Token: 0x020001B7 RID: 439
[Token(Token = "0x20001B7")]
public abstract class UMARecipeBase : ScriptableObject
{
	// Token: 0x06000941 RID: 2369
	[Token(Token = "0x6000941")]
	public abstract void Load(UMAData.UMARecipe umaRecipe, UMAContext context);

	// Token: 0x06000942 RID: 2370
	[Token(Token = "0x6000942")]
	public abstract void Save(UMAData.UMARecipe umaRecipe, UMAContext context);

	// Token: 0x06000943 RID: 2371 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000943")]
	[Address(RVA = "0x25FFD4C", Offset = "0x25FFD4C", VA = "0x7BBCDFFD4C")]
	public UMAData.UMARecipe GetCachedRecipe(UMAContext context)
	{
		return null;
	}

	// Token: 0x06000944 RID: 2372 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000944")]
	[Address(RVA = "0x260987C", Offset = "0x260987C", VA = "0x7BBCE0987C")]
	protected UMARecipeBase()
	{
	}

	// Token: 0x040008D0 RID: 2256
	[Token(Token = "0x40008D0")]
	[FieldOffset(Offset = "0x18")]
	protected UMAData.UMARecipe umaRecipe;

	// Token: 0x040008D1 RID: 2257
	[Token(Token = "0x40008D1")]
	[FieldOffset(Offset = "0x20")]
	protected bool cached;
}
