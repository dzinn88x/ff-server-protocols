using System;
using Il2CppDummyDll;

// Token: 0x0200017B RID: 379
[Token(Token = "0x200017B")]
public class SABoneColliderCommon
{
	// Token: 0x060007D0 RID: 2000 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007D0")]
	[Address(RVA = "0x2255E48", Offset = "0x2255E48", VA = "0x7BBCA55E48")]
	public SABoneColliderCommon()
	{
	}

	// Token: 0x0200017C RID: 380
	[Token(Token = "0x200017C")]
	public enum BoneWeightType
	{
		// Token: 0x040007DC RID: 2012
		[Token(Token = "0x40007DC")]
		Bone2,
		// Token: 0x040007DD RID: 2013
		[Token(Token = "0x40007DD")]
		Bone4
	}

	// Token: 0x0200017D RID: 381
	[Token(Token = "0x200017D")]
	public enum BoneTriangleExtent
	{
		// Token: 0x040007DF RID: 2015
		[Token(Token = "0x40007DF")]
		Disable,
		// Token: 0x040007E0 RID: 2016
		[Token(Token = "0x40007E0")]
		Vertex2,
		// Token: 0x040007E1 RID: 2017
		[Token(Token = "0x40007E1")]
		Vertex1
	}

	// Token: 0x0200017E RID: 382
	[Token(Token = "0x200017E")]
	[Serializable]
	public class BoneProperty
	{
		// Token: 0x060007D1 RID: 2001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x2255E50", Offset = "0x2255E50", VA = "0x7BBCA55E50")]
		public SABoneColliderCommon.BoneProperty ShallowCopy()
		{
			return null;
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x2255F24", Offset = "0x2255F24", VA = "0x7BBCA55F24")]
		public BoneProperty()
		{
		}

		// Token: 0x040007E2 RID: 2018
		[Token(Token = "0x40007E2")]
		[FieldOffset(Offset = "0x10")]
		public bool recursivery;
	}

	// Token: 0x0200017F RID: 383
	[Token(Token = "0x200017F")]
	[Serializable]
	public class SplitProperty
	{
		// Token: 0x060007D3 RID: 2003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x225602C", Offset = "0x225602C", VA = "0x7BBCA5602C")]
		public SABoneColliderCommon.SplitProperty ShallowCopy()
		{
			return null;
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x225647C", Offset = "0x225647C", VA = "0x7BBCA5647C")]
		public SplitProperty()
		{
		}

		// Token: 0x040007E3 RID: 2019
		[Token(Token = "0x40007E3")]
		[FieldOffset(Offset = "0x10")]
		public SABoneColliderCommon.BoneWeightType boneWeightType;

		// Token: 0x040007E4 RID: 2020
		[Token(Token = "0x40007E4")]
		[FieldOffset(Offset = "0x14")]
		public int boneWeight2;

		// Token: 0x040007E5 RID: 2021
		[Token(Token = "0x40007E5")]
		[FieldOffset(Offset = "0x18")]
		public int boneWeight3;

		// Token: 0x040007E6 RID: 2022
		[Token(Token = "0x40007E6")]
		[FieldOffset(Offset = "0x1C")]
		public int boneWeight4;

		// Token: 0x040007E7 RID: 2023
		[Token(Token = "0x40007E7")]
		[FieldOffset(Offset = "0x20")]
		public bool greaterBoneWeight;

		// Token: 0x040007E8 RID: 2024
		[Token(Token = "0x40007E8")]
		[FieldOffset(Offset = "0x24")]
		public SABoneColliderCommon.BoneTriangleExtent boneTriangleExtent;
	}

	// Token: 0x02000180 RID: 384
	[Token(Token = "0x2000180")]
	[Serializable]
	public class SABoneColliderProperty
	{
		// Token: 0x060007D5 RID: 2005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x22565E8", Offset = "0x22565E8", VA = "0x7BBCA565E8")]
		public SABoneColliderCommon.SABoneColliderProperty Copy()
		{
			return null;
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x2255B44", Offset = "0x2255B44", VA = "0x7BBCA55B44")]
		public SABoneColliderProperty()
		{
		}

		// Token: 0x040007E9 RID: 2025
		[Token(Token = "0x40007E9")]
		[FieldOffset(Offset = "0x10")]
		public SABoneColliderCommon.BoneProperty boneProperty;

		// Token: 0x040007EA RID: 2026
		[Token(Token = "0x40007EA")]
		[FieldOffset(Offset = "0x18")]
		public SABoneColliderCommon.SplitProperty splitProperty;

		// Token: 0x040007EB RID: 2027
		[Token(Token = "0x40007EB")]
		[FieldOffset(Offset = "0x20")]
		public SAColliderBuilderCommon.ReducerProperty reducerProperty;

		// Token: 0x040007EC RID: 2028
		[Token(Token = "0x40007EC")]
		[FieldOffset(Offset = "0x28")]
		public SAColliderBuilderCommon.ColliderProperty colliderProperty;

		// Token: 0x040007ED RID: 2029
		[Token(Token = "0x40007ED")]
		[FieldOffset(Offset = "0x30")]
		public SAColliderBuilderCommon.RigidbodyProperty rigidbodyProperty;

		// Token: 0x040007EE RID: 2030
		[Token(Token = "0x40007EE")]
		[FieldOffset(Offset = "0x38")]
		public bool modifyNameEnabled;
	}

	// Token: 0x02000181 RID: 385
	[Token(Token = "0x2000181")]
	[Serializable]
	public class SABoneColliderBuilderProperty
	{
		// Token: 0x060007D7 RID: 2007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x2255F2C", Offset = "0x2255F2C", VA = "0x7BBCA55F2C")]
		public SABoneColliderCommon.SABoneColliderBuilderProperty Copy()
		{
			return null;
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x225637C", Offset = "0x225637C", VA = "0x7BBCA5637C")]
		public SABoneColliderCommon.SABoneColliderProperty ToSABoneColliderProperty()
		{
			return null;
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x2255D34", Offset = "0x2255D34", VA = "0x7BBCA55D34")]
		public SABoneColliderBuilderProperty()
		{
		}

		// Token: 0x040007EF RID: 2031
		[Token(Token = "0x40007EF")]
		[FieldOffset(Offset = "0x10")]
		public SABoneColliderCommon.SplitProperty splitProperty;

		// Token: 0x040007F0 RID: 2032
		[Token(Token = "0x40007F0")]
		[FieldOffset(Offset = "0x18")]
		public SAColliderBuilderCommon.ReducerProperty reducerProperty;

		// Token: 0x040007F1 RID: 2033
		[Token(Token = "0x40007F1")]
		[FieldOffset(Offset = "0x20")]
		public SAColliderBuilderCommon.ColliderProperty colliderProperty;

		// Token: 0x040007F2 RID: 2034
		[Token(Token = "0x40007F2")]
		[FieldOffset(Offset = "0x28")]
		public SAColliderBuilderCommon.RigidbodyProperty rigidbodyProperty;

		// Token: 0x040007F3 RID: 2035
		[Token(Token = "0x40007F3")]
		[FieldOffset(Offset = "0x30")]
		public bool modifyNameEnabled;
	}
}
