using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200001F RID: 31
[Token(Token = "0x200001F")]
public class BezierFollowingObject : ReusableObject
{
	// Token: 0x06000079 RID: 121 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000079")]
	[Address(RVA = "0x1F8BD14", Offset = "0x1F8BD14", VA = "0x7BBC78BD14")]
	public static void StartFollowing(Transform owner, Transform target, Vector3 startPoint, Vector3 turnPoint, bool isUseDefaultTime = true, float followTime = 0.5f)
	{
	}

	// Token: 0x0600007A RID: 122 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600007A")]
	[Address(RVA = "0x1F8BEF8", Offset = "0x1F8BEF8", VA = "0x7BBC78BEF8")]
	public void StartFollow(Transform target, Vector3 startPoint, Vector3 turnPoint, float followTime)
	{
	}

	// Token: 0x0600007B RID: 123 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600007B")]
	[Address(RVA = "0x1F8BF40", Offset = "0x1F8BF40", VA = "0x7BBC78BF40")]
	private void Update()
	{
	}

	// Token: 0x0600007C RID: 124 RVA: 0x00002148 File Offset: 0x00000348
	[Token(Token = "0x600007C")]
	[Address(RVA = "0x1F8C0A0", Offset = "0x1F8C0A0", VA = "0x7BBC78C0A0")]
	private Vector3 GetCurPoint(float t)
	{
		return default(Vector3);
	}

	// Token: 0x0600007D RID: 125 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600007D")]
	[Address(RVA = "0x1F8C1F0", Offset = "0x1F8C1F0", VA = "0x7BBC78C1F0")]
	public BezierFollowingObject()
	{
	}

	// Token: 0x04000092 RID: 146
	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0x2C")]
	public float DefaultFollowTime;

	// Token: 0x04000093 RID: 147
	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0x30")]
	private Transform m_Target;

	// Token: 0x04000094 RID: 148
	[Token(Token = "0x4000094")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 m_StartPoint;

	// Token: 0x04000095 RID: 149
	[Token(Token = "0x4000095")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 m_TurnPoint;

	// Token: 0x04000096 RID: 150
	[Token(Token = "0x4000096")]
	[FieldOffset(Offset = "0x50")]
	private float m_FollowTime;

	// Token: 0x04000097 RID: 151
	[Token(Token = "0x4000097")]
	[FieldOffset(Offset = "0x54")]
	private float m_StartTime;
}
