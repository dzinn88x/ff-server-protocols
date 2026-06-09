using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000178 RID: 376
[Token(Token = "0x2000178")]
public class MotorcycleWheelController : MonoBehaviour, WheelColliderInterface
{
	// Token: 0x0600078C RID: 1932 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600078C")]
	[Address(RVA = "0x228F438", Offset = "0x228F438", VA = "0x7BBCA8F438", Slot = "4")]
	public void AttachWheelModel(Transform model)
	{
	}

	// Token: 0x0600078D RID: 1933 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600078D")]
	[Address(RVA = "0x228F5EC", Offset = "0x228F5EC", VA = "0x7BBCA8F5EC")]
	public void EnableWheelCollider(bool e)
	{
	}

	// Token: 0x0600078E RID: 1934 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600078E")]
	[Address(RVA = "0x228F69C", Offset = "0x228F69C", VA = "0x7BBCA8F69C")]
	private void Update()
	{
	}

	// Token: 0x0600078F RID: 1935 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600078F")]
	[Address(RVA = "0x228FF14", Offset = "0x228FF14", VA = "0x7BBCA8FF14")]
	public MotorcycleWheelController()
	{
	}

	// Token: 0x04000790 RID: 1936
	[Token(Token = "0x4000790")]
	[FieldOffset(Offset = "0x18")]
	public RMCRealisticMotorcycleController m_Controller;

	// Token: 0x04000791 RID: 1937
	[Token(Token = "0x4000791")]
	[FieldOffset(Offset = "0x20")]
	public WheelCollider m_WheelCollider;

	// Token: 0x04000792 RID: 1938
	[Token(Token = "0x4000792")]
	[FieldOffset(Offset = "0x28")]
	public Transform m_WheelTransform;

	// Token: 0x04000793 RID: 1939
	[Token(Token = "0x4000793")]
	[FieldOffset(Offset = "0x30")]
	private float rot;
}
