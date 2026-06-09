using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000161 RID: 353
[Token(Token = "0x2000161")]
[Attribute(Name = "AddComponentMenu", RVA = "0x10E2380", Offset = "0x10E2380")]
public class DynamicBoneCollider : MonoBehaviour
{
	// Token: 0x060006D6 RID: 1750 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006D6")]
	[Address(RVA = "0x23EBE2C", Offset = "0x23EBE2C", VA = "0x7BBCBEBE2C")]
	private void OnValidate()
	{
	}

	// Token: 0x060006D7 RID: 1751 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006D7")]
	[Address(RVA = "0x23EB9A0", Offset = "0x23EB9A0", VA = "0x7BBCBEB9A0")]
	public void Collide(ref Vector3 particlePosition, float particleRadius)
	{
	}

	// Token: 0x060006D8 RID: 1752 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006D8")]
	[Address(RVA = "0x23ECA48", Offset = "0x23ECA48", VA = "0x7BBCBECA48")]
	public void PostCollide(ref Vector3 particlePosition, ref Vector3 parentParticlePosition, float particleRadius)
	{
	}

	// Token: 0x060006D9 RID: 1753 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006D9")]
	[Address(RVA = "0x23EBEC4", Offset = "0x23EBEC4", VA = "0x7BBCBEBEC4")]
	private static void OutsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius)
	{
	}

	// Token: 0x060006DA RID: 1754 RVA: 0x00003300 File Offset: 0x00001500
	[Token(Token = "0x60006DA")]
	[Address(RVA = "0x23ECE3C", Offset = "0x23ECE3C", VA = "0x7BBCBECE3C")]
	private static Vector3 OutsideSphereDelta(Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius)
	{
		return default(Vector3);
	}

	// Token: 0x060006DB RID: 1755 RVA: 0x00003318 File Offset: 0x00001518
	[Token(Token = "0x60006DB")]
	[Address(RVA = "0x23ECFE8", Offset = "0x23ECFE8", VA = "0x7BBCBECFE8")]
	private static Vector3 OutsideCapsuleDelta(Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius)
	{
		return default(Vector3);
	}

	// Token: 0x060006DC RID: 1756 RVA: 0x00003330 File Offset: 0x00001530
	[Token(Token = "0x60006DC")]
	[Address(RVA = "0x23ED2A4", Offset = "0x23ED2A4", VA = "0x7BBCBED2A4")]
	private static Vector3 LinePointProjection(Vector3 P, Vector3 A, Vector3 B)
	{
		return default(Vector3);
	}

	// Token: 0x060006DD RID: 1757 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006DD")]
	[Address(RVA = "0x23EC058", Offset = "0x23EC058", VA = "0x7BBCBEC058")]
	private static void InsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius)
	{
	}

	// Token: 0x060006DE RID: 1758 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006DE")]
	[Address(RVA = "0x23EC1FC", Offset = "0x23EC1FC", VA = "0x7BBCBEC1FC")]
	private static void OutsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius)
	{
	}

	// Token: 0x060006DF RID: 1759 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006DF")]
	[Address(RVA = "0x23EC638", Offset = "0x23EC638", VA = "0x7BBCBEC638")]
	private static void InsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius)
	{
	}

	// Token: 0x060006E0 RID: 1760 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006E0")]
	[Address(RVA = "0x23ED404", Offset = "0x23ED404", VA = "0x7BBCBED404")]
	private void OnDrawGizmosSelected()
	{
	}

	// Token: 0x060006E1 RID: 1761 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006E1")]
	[Address(RVA = "0x23ED5F0", Offset = "0x23ED5F0", VA = "0x7BBCBED5F0")]
	public DynamicBoneCollider()
	{
	}

	// Token: 0x0400064F RID: 1615
	[Token(Token = "0x400064F")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 m_Center;

	// Token: 0x04000650 RID: 1616
	[Token(Token = "0x4000650")]
	[FieldOffset(Offset = "0x24")]
	public float m_Radius;

	// Token: 0x04000651 RID: 1617
	[Token(Token = "0x4000651")]
	[FieldOffset(Offset = "0x28")]
	public float m_Height;

	// Token: 0x04000652 RID: 1618
	[Token(Token = "0x4000652")]
	[FieldOffset(Offset = "0x2C")]
	public DynamicBoneCollider.Direction m_Direction;

	// Token: 0x04000653 RID: 1619
	[Token(Token = "0x4000653")]
	[FieldOffset(Offset = "0x30")]
	public DynamicBoneCollider.Bound m_Bound;

	// Token: 0x02000162 RID: 354
	[Token(Token = "0x2000162")]
	public enum Direction
	{
		// Token: 0x04000655 RID: 1621
		[Token(Token = "0x4000655")]
		X,
		// Token: 0x04000656 RID: 1622
		[Token(Token = "0x4000656")]
		Y,
		// Token: 0x04000657 RID: 1623
		[Token(Token = "0x4000657")]
		Z
	}

	// Token: 0x02000163 RID: 355
	[Token(Token = "0x2000163")]
	public enum Bound
	{
		// Token: 0x04000659 RID: 1625
		[Token(Token = "0x4000659")]
		Outside,
		// Token: 0x0400065A RID: 1626
		[Token(Token = "0x400065A")]
		Inside
	}
}
