using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000182 RID: 386
[Token(Token = "0x2000182")]
public class SAColliderBuilderCommon
{
	// Token: 0x060007DA RID: 2010 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007DA")]
	[Address(RVA = "0x2256708", Offset = "0x2256708", VA = "0x7BBCA56708")]
	public SAColliderBuilderCommon()
	{
	}

	// Token: 0x02000183 RID: 387
	[Token(Token = "0x2000183")]
	public enum ShapeType
	{
		// Token: 0x040007F5 RID: 2037
		[Token(Token = "0x40007F5")]
		None,
		// Token: 0x040007F6 RID: 2038
		[Token(Token = "0x40007F6")]
		Mesh,
		// Token: 0x040007F7 RID: 2039
		[Token(Token = "0x40007F7")]
		Box,
		// Token: 0x040007F8 RID: 2040
		[Token(Token = "0x40007F8")]
		Capsule,
		// Token: 0x040007F9 RID: 2041
		[Token(Token = "0x40007F9")]
		Sphere
	}

	// Token: 0x02000184 RID: 388
	[Token(Token = "0x2000184")]
	public enum FitType
	{
		// Token: 0x040007FB RID: 2043
		[Token(Token = "0x40007FB")]
		Outer,
		// Token: 0x040007FC RID: 2044
		[Token(Token = "0x40007FC")]
		Inner
	}

	// Token: 0x02000185 RID: 389
	[Token(Token = "0x2000185")]
	public enum MeshType
	{
		// Token: 0x040007FE RID: 2046
		[Token(Token = "0x40007FE")]
		Raw,
		// Token: 0x040007FF RID: 2047
		[Token(Token = "0x40007FF")]
		ConvexBoxes,
		// Token: 0x04000800 RID: 2048
		[Token(Token = "0x4000800")]
		ConvexHull,
		// Token: 0x04000801 RID: 2049
		[Token(Token = "0x4000801")]
		Box
	}

	// Token: 0x02000186 RID: 390
	[Token(Token = "0x2000186")]
	public enum SliceMode
	{
		// Token: 0x04000803 RID: 2051
		[Token(Token = "0x4000803")]
		Auto,
		// Token: 0x04000804 RID: 2052
		[Token(Token = "0x4000804")]
		X,
		// Token: 0x04000805 RID: 2053
		[Token(Token = "0x4000805")]
		Y,
		// Token: 0x04000806 RID: 2054
		[Token(Token = "0x4000806")]
		Z
	}

	// Token: 0x02000187 RID: 391
	[Token(Token = "0x2000187")]
	public enum ElementType
	{
		// Token: 0x04000808 RID: 2056
		[Token(Token = "0x4000808")]
		X,
		// Token: 0x04000809 RID: 2057
		[Token(Token = "0x4000809")]
		XYZ
	}

	// Token: 0x02000188 RID: 392
	[Token(Token = "0x2000188")]
	[Serializable]
	public struct Bool3
	{
		// Token: 0x060007DB RID: 2011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x11F1D28", Offset = "0x11F1D28", VA = "0x7BBB9F1D28")]
		public Bool3(bool x, bool y, bool z)
		{
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x11F1D44", Offset = "0x11F1D44", VA = "0x7BBB9F1D44")]
		public void SetValue(bool x, bool y, bool z)
		{
		}

		// Token: 0x0400080A RID: 2058
		[Token(Token = "0x400080A")]
		[FieldOffset(Offset = "0x0")]
		public bool x;

		// Token: 0x0400080B RID: 2059
		[Token(Token = "0x400080B")]
		[FieldOffset(Offset = "0x1")]
		public bool y;

		// Token: 0x0400080C RID: 2060
		[Token(Token = "0x400080C")]
		[FieldOffset(Offset = "0x2")]
		public bool z;
	}

	// Token: 0x02000189 RID: 393
	[Token(Token = "0x2000189")]
	public enum ColliderToChild
	{
		// Token: 0x0400080E RID: 2062
		[Token(Token = "0x400080E")]
		Auto,
		// Token: 0x0400080F RID: 2063
		[Token(Token = "0x400080F")]
		On,
		// Token: 0x04000810 RID: 2064
		[Token(Token = "0x4000810")]
		Off
	}

	// Token: 0x0200018A RID: 394
	[Token(Token = "0x200018A")]
	[Serializable]
	public class ReducerProperty
	{
		// Token: 0x060007DD RID: 2013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x2256100", Offset = "0x2256100", VA = "0x7BBCA56100")]
		public SAColliderBuilderCommon.ReducerProperty ShallowCopy()
		{
			return null;
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x22564A4", Offset = "0x22564A4", VA = "0x7BBCA564A4")]
		public ReducerProperty()
		{
		}

		// Token: 0x04000811 RID: 2065
		[Token(Token = "0x4000811")]
		[FieldOffset(Offset = "0x10")]
		public SAColliderBuilderCommon.ShapeType shapeType;

		// Token: 0x04000812 RID: 2066
		[Token(Token = "0x4000812")]
		[FieldOffset(Offset = "0x14")]
		public SAColliderBuilderCommon.FitType fitType;

		// Token: 0x04000813 RID: 2067
		[Token(Token = "0x4000813")]
		[FieldOffset(Offset = "0x18")]
		public SAColliderBuilderCommon.MeshType meshType;

		// Token: 0x04000814 RID: 2068
		[Token(Token = "0x4000814")]
		[FieldOffset(Offset = "0x1C")]
		public int maxTriangles;

		// Token: 0x04000815 RID: 2069
		[Token(Token = "0x4000815")]
		[FieldOffset(Offset = "0x20")]
		public SAColliderBuilderCommon.SliceMode sliceMode;

		// Token: 0x04000816 RID: 2070
		[Token(Token = "0x4000816")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 scale;

		// Token: 0x04000817 RID: 2071
		[Token(Token = "0x4000817")]
		[FieldOffset(Offset = "0x30")]
		public SAColliderBuilderCommon.ElementType scaleElementType;

		// Token: 0x04000818 RID: 2072
		[Token(Token = "0x4000818")]
		[FieldOffset(Offset = "0x34")]
		public Vector3 minThickness;

		// Token: 0x04000819 RID: 2073
		[Token(Token = "0x4000819")]
		[FieldOffset(Offset = "0x40")]
		public SAColliderBuilderCommon.ElementType minThicknessElementType;

		// Token: 0x0400081A RID: 2074
		[Token(Token = "0x400081A")]
		[FieldOffset(Offset = "0x44")]
		public SAColliderBuilderCommon.Bool3 optimizeRotation;

		// Token: 0x0400081B RID: 2075
		[Token(Token = "0x400081B")]
		[FieldOffset(Offset = "0x48")]
		public SAColliderBuilderCommon.ElementType optimizeRotationElementType;

		// Token: 0x0400081C RID: 2076
		[Token(Token = "0x400081C")]
		[FieldOffset(Offset = "0x4C")]
		public SAColliderBuilderCommon.ColliderToChild colliderToChild;

		// Token: 0x0400081D RID: 2077
		[Token(Token = "0x400081D")]
		[FieldOffset(Offset = "0x50")]
		public Vector3 offset;

		// Token: 0x0400081E RID: 2078
		[Token(Token = "0x400081E")]
		[FieldOffset(Offset = "0x5C")]
		public Vector3 thicknessA;

		// Token: 0x0400081F RID: 2079
		[Token(Token = "0x400081F")]
		[FieldOffset(Offset = "0x68")]
		public Vector3 thicknessB;

		// Token: 0x04000820 RID: 2080
		[Token(Token = "0x4000820")]
		[FieldOffset(Offset = "0x74")]
		public bool viewAdvanced;
	}

	// Token: 0x0200018B RID: 395
	[Token(Token = "0x200018B")]
	[Serializable]
	public class ColliderProperty
	{
		// Token: 0x060007DF RID: 2015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x22561D4", Offset = "0x22561D4", VA = "0x7BBCA561D4")]
		public SAColliderBuilderCommon.ColliderProperty ShallowCopy()
		{
			return null;
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x22565B0", Offset = "0x22565B0", VA = "0x7BBCA565B0")]
		public ColliderProperty()
		{
		}

		// Token: 0x04000821 RID: 2081
		[Token(Token = "0x4000821")]
		[FieldOffset(Offset = "0x10")]
		public bool convex;

		// Token: 0x04000822 RID: 2082
		[Token(Token = "0x4000822")]
		[FieldOffset(Offset = "0x11")]
		public bool isTrigger;

		// Token: 0x04000823 RID: 2083
		[Token(Token = "0x4000823")]
		[FieldOffset(Offset = "0x18")]
		public PhysicMaterial material;

		// Token: 0x04000824 RID: 2084
		[Token(Token = "0x4000824")]
		[FieldOffset(Offset = "0x20")]
		public bool isCreateAsset;
	}

	// Token: 0x0200018C RID: 396
	[Token(Token = "0x200018C")]
	[Serializable]
	public class RigidbodyProperty
	{
		// Token: 0x060007E1 RID: 2017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x22562A8", Offset = "0x22562A8", VA = "0x7BBCA562A8")]
		public SAColliderBuilderCommon.RigidbodyProperty ShallowCopy()
		{
			return null;
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x22565C0", Offset = "0x22565C0", VA = "0x7BBCA565C0")]
		public RigidbodyProperty()
		{
		}

		// Token: 0x04000825 RID: 2085
		[Token(Token = "0x4000825")]
		[FieldOffset(Offset = "0x10")]
		public float mass;

		// Token: 0x04000826 RID: 2086
		[Token(Token = "0x4000826")]
		[FieldOffset(Offset = "0x14")]
		public float drag;

		// Token: 0x04000827 RID: 2087
		[Token(Token = "0x4000827")]
		[FieldOffset(Offset = "0x18")]
		public float angularDrag;

		// Token: 0x04000828 RID: 2088
		[Token(Token = "0x4000828")]
		[FieldOffset(Offset = "0x1C")]
		public bool isKinematic;

		// Token: 0x04000829 RID: 2089
		[Token(Token = "0x4000829")]
		[FieldOffset(Offset = "0x1D")]
		public bool useGravity;

		// Token: 0x0400082A RID: 2090
		[Token(Token = "0x400082A")]
		[FieldOffset(Offset = "0x20")]
		public RigidbodyInterpolation interpolation;

		// Token: 0x0400082B RID: 2091
		[Token(Token = "0x400082B")]
		[FieldOffset(Offset = "0x24")]
		public CollisionDetectionMode collisionDetectionMode;

		// Token: 0x0400082C RID: 2092
		[Token(Token = "0x400082C")]
		[FieldOffset(Offset = "0x28")]
		public bool isCreate;

		// Token: 0x0400082D RID: 2093
		[Token(Token = "0x400082D")]
		[FieldOffset(Offset = "0x29")]
		public bool viewAdvanced;
	}
}
