using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001F7 RID: 503
[Token(Token = "0x20001F7")]
public class LODExtendedUtility
{
	// Token: 0x06000A12 RID: 2578 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A12")]
	[Address(RVA = "0x24D3EFC", Offset = "0x24D3EFC", VA = "0x7BBCCD3EFC")]
	public static LODGroup GetParentLODGroupComponent(GameObject GO)
	{
		return null;
	}

	// Token: 0x06000A13 RID: 2579 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A13")]
	[Address(RVA = "0x24D4098", Offset = "0x24D4098", VA = "0x7BBCCD4098")]
	public static GameObject GetParentLODGroupGameObject(GameObject GO)
	{
		return null;
	}

	// Token: 0x06000A14 RID: 2580 RVA: 0x00003E70 File Offset: 0x00002070
	[Token(Token = "0x6000A14")]
	[Address(RVA = "0x24D4140", Offset = "0x24D4140", VA = "0x7BBCCD4140")]
	public static int GetLODid(GameObject GO)
	{
		return 0;
	}

	// Token: 0x06000A15 RID: 2581 RVA: 0x00003E88 File Offset: 0x00002088
	[Token(Token = "0x6000A15")]
	[Address(RVA = "0x24D42B0", Offset = "0x24D42B0", VA = "0x7BBCCD42B0")]
	public static int GetVisibleLOD(LODGroup lodGroup, [Optional] Camera camera)
	{
		return 0;
	}

	// Token: 0x06000A16 RID: 2582 RVA: 0x00003EA0 File Offset: 0x000020A0
	[Token(Token = "0x6000A16")]
	[Address(RVA = "0x24D437C", Offset = "0x24D437C", VA = "0x7BBCCD437C")]
	private static float GetRelativeHeight(LODGroup lodGroup, Camera camera)
	{
		return 0f;
	}

	// Token: 0x06000A17 RID: 2583 RVA: 0x00003EB8 File Offset: 0x000020B8
	[Token(Token = "0x6000A17")]
	[Address(RVA = "0x24D45B8", Offset = "0x24D45B8", VA = "0x7BBCCD45B8")]
	public static float DistanceToRelativeHeight(Camera camera, float distance, float size)
	{
		return 0f;
	}

	// Token: 0x06000A18 RID: 2584 RVA: 0x00003ED0 File Offset: 0x000020D0
	[Token(Token = "0x6000A18")]
	[Address(RVA = "0x24D4528", Offset = "0x24D4528", VA = "0x7BBCCD4528")]
	public static int GetMaxLOD(LODGroup lodGroup)
	{
		return 0;
	}

	// Token: 0x06000A19 RID: 2585 RVA: 0x00003EE8 File Offset: 0x000020E8
	[Token(Token = "0x6000A19")]
	[Address(RVA = "0x24D455C", Offset = "0x24D455C", VA = "0x7BBCCD455C")]
	public static float GetWorldSpaceSize(LODGroup lodGroup)
	{
		return 0f;
	}

	// Token: 0x06000A1A RID: 2586 RVA: 0x00003F00 File Offset: 0x00002100
	[Token(Token = "0x6000A1A")]
	[Address(RVA = "0x24D46B0", Offset = "0x24D46B0", VA = "0x7BBCCD46B0")]
	private static float GetWorldSpaceScale(Transform t)
	{
		return 0f;
	}

	// Token: 0x06000A1B RID: 2587 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A1B")]
	[Address(RVA = "0x24D475C", Offset = "0x24D475C", VA = "0x7BBCCD475C")]
	public LODExtendedUtility()
	{
	}

	// Token: 0x020001F8 RID: 504
	[Token(Token = "0x20001F8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E2640", Offset = "0x10E2640")]
	private sealed class <>c__DisplayClass0_0
	{
		// Token: 0x06000A1C RID: 2588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x24D4090", Offset = "0x24D4090", VA = "0x7BBCCD4090")]
		public <>c__DisplayClass0_0()
		{
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x00003F18 File Offset: 0x00002118
		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x24D4764", Offset = "0x24D4764", VA = "0x7BBCCD4764")]
		internal bool <GetParentLODGroupComponent>b__0(LOD lod)
		{
			return default(bool);
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x00003F30 File Offset: 0x00002130
		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x24D4830", Offset = "0x24D4830", VA = "0x7BBCCD4830")]
		internal bool <GetParentLODGroupComponent>b__1(Renderer renderer)
		{
			return default(bool);
		}

		// Token: 0x04000981 RID: 2433
		[Token(Token = "0x4000981")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject GO;

		// Token: 0x04000982 RID: 2434
		[Token(Token = "0x4000982")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<Renderer, bool> <>9__1;
	}

	// Token: 0x020001F9 RID: 505
	[Token(Token = "0x20001F9")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E2650", Offset = "0x10E2650")]
	private sealed class <>c__DisplayClass2_0
	{
		// Token: 0x06000A1F RID: 2591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x24D42A8", Offset = "0x24D42A8", VA = "0x7BBCCD42A8")]
		public <>c__DisplayClass2_0()
		{
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x00003F48 File Offset: 0x00002148
		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x24D48D4", Offset = "0x24D48D4", VA = "0x7BBCCD48D4")]
		internal bool <GetLODid>b__0(LOD lod)
		{
			return default(bool);
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x00003F60 File Offset: 0x00002160
		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x24D49A0", Offset = "0x24D49A0", VA = "0x7BBCCD49A0")]
		internal bool <GetLODid>b__1(Renderer renderer)
		{
			return default(bool);
		}

		// Token: 0x04000983 RID: 2435
		[Token(Token = "0x4000983")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject GO;

		// Token: 0x04000984 RID: 2436
		[Token(Token = "0x4000984")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<Renderer, bool> <>9__1;
	}
}
