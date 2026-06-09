using System;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000048 RID: 72
[Token(Token = "0x2000048")]
public class PreparePhaseCameraPivot : MonoBehaviour, \u007F{KyDPR
{
	// Token: 0x060000D1 RID: 209 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x23CAD20", Offset = "0x23CAD20", VA = "0x7BBCBCAD20")]
	private void Awake()
	{
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x000021A8 File Offset: 0x000003A8
	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x23CADA8", Offset = "0x23CADA8", VA = "0x7BBCBCADA8", Slot = "4")]
	public Vector3 GetCameraTrackableEntityPosition()
	{
		return default(Vector3);
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x000021C0 File Offset: 0x000003C0
	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x23CADD8", Offset = "0x23CADD8", VA = "0x7BBCBCADD8", Slot = "5")]
	public Vector3 GetCameraTrackableEntityTopPosition()
	{
		return default(Vector3);
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x000021D8 File Offset: 0x000003D8
	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x23CAE08", Offset = "0x23CAE08", VA = "0x7BBCBCAE08", Slot = "6")]
	public Quaternion GetCameraTrackableEntityAimRotation()
	{
		return default(Quaternion);
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x23CAE38", Offset = "0x23CAE38", VA = "0x7BBCBCAE38", Slot = "7")]
	public Transform GetCameraTrackableEntityTransfrom()
	{
		return null;
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x000021F0 File Offset: 0x000003F0
	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x23CAE40", Offset = "0x23CAE40", VA = "0x7BBCBCAE40", Slot = "8")]
	public bool IsCameraTrackableEntityAlive()
	{
		return default(bool);
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x23CAE48", Offset = "0x23CAE48", VA = "0x7BBCBCAE48")]
	public PreparePhaseCameraPivot()
	{
	}

	// Token: 0x040000FF RID: 255
	[Token(Token = "0x40000FF")]
	[FieldOffset(Offset = "0x18")]
	private Transform m_CachTransform;
}
