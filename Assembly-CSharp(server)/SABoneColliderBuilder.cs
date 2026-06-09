using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200018E RID: 398
[Token(Token = "0x200018E")]
public class SABoneColliderBuilder : MonoBehaviour
{
	// Token: 0x17000091 RID: 145
	// (get) Token: 0x060007F2 RID: 2034 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000091")]
	public SABoneColliderCommon.SplitProperty splitProperty
	{
		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x2255C70", Offset = "0x2255C70", VA = "0x7BBCA55C70")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000092 RID: 146
	// (get) Token: 0x060007F3 RID: 2035 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000092")]
	public SAColliderBuilderCommon.ReducerProperty reducerProperty
	{
		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x2255C88", Offset = "0x2255C88", VA = "0x7BBCA55C88")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000093 RID: 147
	// (get) Token: 0x060007F4 RID: 2036 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000093")]
	public SAColliderBuilderCommon.ColliderProperty colliderProperty
	{
		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x2255CA0", Offset = "0x2255CA0", VA = "0x7BBCA55CA0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000094 RID: 148
	// (get) Token: 0x060007F5 RID: 2037 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000094")]
	public SAColliderBuilderCommon.RigidbodyProperty rigidbodyProperty
	{
		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x2255CB8", Offset = "0x2255CB8", VA = "0x7BBCA55CB8")]
		get
		{
			return null;
		}
	}

	// Token: 0x060007F6 RID: 2038 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F6")]
	[Address(RVA = "0x2255CD0", Offset = "0x2255CD0", VA = "0x7BBCA55CD0")]
	public SABoneColliderBuilder()
	{
	}

	// Token: 0x04000836 RID: 2102
	[Token(Token = "0x4000836")]
	[FieldOffset(Offset = "0x18")]
	public SABoneColliderCommon.SABoneColliderBuilderProperty boneColliderBuilderProperty;

	// Token: 0x04000837 RID: 2103
	[Token(Token = "0x4000837")]
	[FieldOffset(Offset = "0x20")]
	[NonSerialized]
	public SABoneColliderCommon.SABoneColliderBuilderProperty edittingBoneColliderBuilderProperty;

	// Token: 0x04000838 RID: 2104
	[Token(Token = "0x4000838")]
	[FieldOffset(Offset = "0x28")]
	[NonSerialized]
	public bool cleanupModified;

	// Token: 0x04000839 RID: 2105
	[Token(Token = "0x4000839")]
	[FieldOffset(Offset = "0x29")]
	[NonSerialized]
	public bool isDebug;
}
