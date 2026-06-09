using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000BD RID: 189
[Token(Token = "0x20000BD")]
public class PlayerColliderChecker : MonoBehaviour
{
	// Token: 0x06000310 RID: 784 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000310")]
	[Address(RVA = "0x23C1E40", Offset = "0x23C1E40", VA = "0x7BBCBC1E40")]
	public PlayerColliderChecker()
	{
	}

	// Token: 0x06000311 RID: 785 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000311")]
	[Address(RVA = "0x23C229C", Offset = "0x23C229C", VA = "0x7BBCBC229C", Slot = "1")]
	protected override void Finalize()
	{
	}

	// Token: 0x06000312 RID: 786 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000312")]
	[Address(RVA = "0x23C22A4", Offset = "0x23C22A4", VA = "0x7BBCBC22A4")]
	public void Start()
	{
	}

	// Token: 0x06000313 RID: 787 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000313")]
	[Address(RVA = "0x23C22A8", Offset = "0x23C22A8", VA = "0x7BBCBC22A8")]
	public void ActiveColliders()
	{
	}

	// Token: 0x06000314 RID: 788 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000314")]
	[Address(RVA = "0x23C2384", Offset = "0x23C2384", VA = "0x7BBCBC2384")]
	public void FindColliders()
	{
	}

	// Token: 0x06000315 RID: 789 RVA: 0x00002868 File Offset: 0x00000A68
	[Token(Token = "0x6000315")]
	[Address(RVA = "0x23C2600", Offset = "0x23C2600", VA = "0x7BBCBC2600")]
	public PlayerColliderChecker.HitPart GetPartByCollider(Collider c)
	{
		return PlayerColliderChecker.HitPart.Head;
	}

	// Token: 0x06000316 RID: 790 RVA: 0x00002880 File Offset: 0x00000A80
	[Token(Token = "0x6000316")]
	[Address(RVA = "0x23C2720", Offset = "0x23C2720", VA = "0x7BBCBC2720")]
	public static int GetPartsMask(List<PlayerColliderChecker.ViewBoxPart> checkPartList)
	{
		return 0;
	}

	// Token: 0x040002F8 RID: 760
	[Token(Token = "0x40002F8")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<string, PlayerColliderChecker.HitPart> HitBoneDict;

	// Token: 0x040002F9 RID: 761
	[Token(Token = "0x40002F9")]
	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public List<ColliderInfo> m_colliderInfoList;

	// Token: 0x020000BE RID: 190
	[Token(Token = "0x20000BE")]
	public enum HitPart
	{
		// Token: 0x040002FB RID: 763
		[Token(Token = "0x40002FB")]
		Head,
		// Token: 0x040002FC RID: 764
		[Token(Token = "0x40002FC")]
		Neck,
		// Token: 0x040002FD RID: 765
		[Token(Token = "0x40002FD")]
		Chest,
		// Token: 0x040002FE RID: 766
		[Token(Token = "0x40002FE")]
		Hips,
		// Token: 0x040002FF RID: 767
		[Token(Token = "0x40002FF")]
		LeftArm,
		// Token: 0x04000300 RID: 768
		[Token(Token = "0x4000300")]
		LeftForeArm,
		// Token: 0x04000301 RID: 769
		[Token(Token = "0x4000301")]
		RightArm,
		// Token: 0x04000302 RID: 770
		[Token(Token = "0x4000302")]
		RightForeArm,
		// Token: 0x04000303 RID: 771
		[Token(Token = "0x4000303")]
		LeftUpLeg,
		// Token: 0x04000304 RID: 772
		[Token(Token = "0x4000304")]
		LeftLeg,
		// Token: 0x04000305 RID: 773
		[Token(Token = "0x4000305")]
		RightUpLeg,
		// Token: 0x04000306 RID: 774
		[Token(Token = "0x4000306")]
		RightLeg,
		// Token: 0x04000307 RID: 775
		[Token(Token = "0x4000307")]
		LeftFoot,
		// Token: 0x04000308 RID: 776
		[Token(Token = "0x4000308")]
		RightFoot,
		// Token: 0x04000309 RID: 777
		[Token(Token = "0x4000309")]
		LeftHand,
		// Token: 0x0400030A RID: 778
		[Token(Token = "0x400030A")]
		RightHand,
		// Token: 0x0400030B RID: 779
		[Token(Token = "0x400030B")]
		LeftClav,
		// Token: 0x0400030C RID: 780
		[Token(Token = "0x400030C")]
		RightClav,
		// Token: 0x0400030D RID: 781
		[Token(Token = "0x400030D")]
		NoFlag,
		// Token: 0x0400030E RID: 782
		[Token(Token = "0x400030E")]
		WeakPoint,
		// Token: 0x0400030F RID: 783
		[Token(Token = "0x400030F")]
		None
	}

	// Token: 0x020000BF RID: 191
	[Token(Token = "0x20000BF")]
	public enum ViewBoxPart
	{
		// Token: 0x04000311 RID: 785
		[Token(Token = "0x4000311")]
		Chest,
		// Token: 0x04000312 RID: 786
		[Token(Token = "0x4000312")]
		Head,
		// Token: 0x04000313 RID: 787
		[Token(Token = "0x4000313")]
		Neck,
		// Token: 0x04000314 RID: 788
		[Token(Token = "0x4000314")]
		Arm,
		// Token: 0x04000315 RID: 789
		[Token(Token = "0x4000315")]
		ForeArm,
		// Token: 0x04000316 RID: 790
		[Token(Token = "0x4000316")]
		UpLeg,
		// Token: 0x04000317 RID: 791
		[Token(Token = "0x4000317")]
		Leg,
		// Token: 0x04000318 RID: 792
		[Token(Token = "0x4000318")]
		Foot
	}
}
