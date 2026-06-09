using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000235 RID: 565
[Token(Token = "0x2000235")]
public class UIGyroMove : MonoBehaviour
{
	// Token: 0x06000B49 RID: 2889 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B49")]
	[Address(RVA = "0x1CA8F28", Offset = "0x1CA8F28", VA = "0x7BBC4A8F28")]
	private void Start()
	{
	}

	// Token: 0x06000B4A RID: 2890 RVA: 0x00004830 File Offset: 0x00002A30
	[Token(Token = "0x6000B4A")]
	[Address(RVA = "0x1CA8F70", Offset = "0x1CA8F70", VA = "0x7BBC4A8F70")]
	public bool IsEnable()
	{
		return default(bool);
	}

	// Token: 0x06000B4B RID: 2891 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B4B")]
	[Address(RVA = "0x1CA9000", Offset = "0x1CA9000", VA = "0x7BBC4A9000")]
	public void EnableGyro(bool v)
	{
	}

	// Token: 0x06000B4C RID: 2892 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B4C")]
	[Address(RVA = "0x1CA900C", Offset = "0x1CA900C", VA = "0x7BBC4A900C")]
	public void SetMoveSpeed(float speed)
	{
	}

	// Token: 0x06000B4D RID: 2893 RVA: 0x00004848 File Offset: 0x00002A48
	[Token(Token = "0x6000B4D")]
	[Address(RVA = "0x1CA9014", Offset = "0x1CA9014", VA = "0x7BBC4A9014")]
	public float MoveSpeed()
	{
		return 0f;
	}

	// Token: 0x06000B4E RID: 2894 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B4E")]
	[Address(RVA = "0x1CA901C", Offset = "0x1CA901C", VA = "0x7BBC4A901C")]
	public void SetRebackSpeed(float speed)
	{
	}

	// Token: 0x06000B4F RID: 2895 RVA: 0x00004860 File Offset: 0x00002A60
	[Token(Token = "0x6000B4F")]
	[Address(RVA = "0x1CA9024", Offset = "0x1CA9024", VA = "0x7BBC4A9024")]
	public float RebackSpeed()
	{
		return 0f;
	}

	// Token: 0x06000B50 RID: 2896 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B50")]
	[Address(RVA = "0x1CA902C", Offset = "0x1CA902C", VA = "0x7BBC4A902C")]
	public void SetXLimit(float limit)
	{
	}

	// Token: 0x06000B51 RID: 2897 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B51")]
	[Address(RVA = "0x1CA9034", Offset = "0x1CA9034", VA = "0x7BBC4A9034")]
	public void SetYLimit(float limit)
	{
	}

	// Token: 0x06000B52 RID: 2898 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B52")]
	[Address(RVA = "0x1CA903C", Offset = "0x1CA903C", VA = "0x7BBC4A903C")]
	private void Update()
	{
	}

	// Token: 0x06000B53 RID: 2899 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B53")]
	[Address(RVA = "0x1CA92D0", Offset = "0x1CA92D0", VA = "0x7BBC4A92D0")]
	public UIGyroMove()
	{
	}

	// Token: 0x04000A45 RID: 2629
	[Token(Token = "0x4000A45")]
	[FieldOffset(Offset = "0x18")]
	public bool m_EnableGyro;

	// Token: 0x04000A46 RID: 2630
	[Token(Token = "0x4000A46")]
	[FieldOffset(Offset = "0x1C")]
	public float m_MoveSpeed;

	// Token: 0x04000A47 RID: 2631
	[Token(Token = "0x4000A47")]
	[FieldOffset(Offset = "0x20")]
	public float m_RebackSpeed;

	// Token: 0x04000A48 RID: 2632
	[Token(Token = "0x4000A48")]
	[FieldOffset(Offset = "0x24")]
	public float m_XLimit;

	// Token: 0x04000A49 RID: 2633
	[Token(Token = "0x4000A49")]
	[FieldOffset(Offset = "0x28")]
	public float m_YLimit;

	// Token: 0x04000A4A RID: 2634
	[Token(Token = "0x4000A4A")]
	[FieldOffset(Offset = "0x30")]
	private Transform m_Transform;

	// Token: 0x04000A4B RID: 2635
	[Token(Token = "0x4000A4B")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 m_OriginPosition;
}
