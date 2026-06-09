using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000056 RID: 86
[Token(Token = "0x2000056")]
internal class TransformRotater
{
	// Token: 0x060000F8 RID: 248 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x22667C4", Offset = "0x22667C4", VA = "0x7BBCA667C4")]
	public void Init(bool reset)
	{
	}

	// Token: 0x060000F9 RID: 249 RVA: 0x00002238 File Offset: 0x00000438
	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x2266C28", Offset = "0x2266C28", VA = "0x7BBCA66C28")]
	private bool NeedUpdate(Transform tr, float current, float val)
	{
		return default(bool);
	}

	// Token: 0x060000FA RID: 250 RVA: 0x00002250 File Offset: 0x00000450
	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x2266984", Offset = "0x2266984", VA = "0x7BBCA66984")]
	public bool RotateToEular(float x, float y, float z)
	{
		return default(bool);
	}

	// Token: 0x060000FB RID: 251 RVA: 0x00002268 File Offset: 0x00000468
	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x2266CEC", Offset = "0x2266CEC", VA = "0x7BBCA66CEC")]
	public bool RotateToDir(Vector3 targetPoint, float maxAngles = 360f)
	{
		return default(bool);
	}

	// Token: 0x060000FC RID: 252 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x2266E60", Offset = "0x2266E60", VA = "0x7BBCA66E60")]
	public TransformRotater()
	{
	}

	// Token: 0x04000114 RID: 276
	[Token(Token = "0x4000114")]
	[FieldOffset(Offset = "0x10")]
	public Transform Root;

	// Token: 0x04000115 RID: 277
	[Token(Token = "0x4000115")]
	[FieldOffset(Offset = "0x18")]
	public Transform RotX;

	// Token: 0x04000116 RID: 278
	[Token(Token = "0x4000116")]
	[FieldOffset(Offset = "0x20")]
	public Transform RotY;

	// Token: 0x04000117 RID: 279
	[Token(Token = "0x4000117")]
	[FieldOffset(Offset = "0x28")]
	public Transform RotZ;

	// Token: 0x04000118 RID: 280
	[Token(Token = "0x4000118")]
	[FieldOffset(Offset = "0x30")]
	public Transform Center;

	// Token: 0x04000119 RID: 281
	[Token(Token = "0x4000119")]
	[FieldOffset(Offset = "0x38")]
	public TransformRotaterAngleCalculator AngleCalculator;

	// Token: 0x0400011A RID: 282
	[Token(Token = "0x400011A")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 m_CurrentRotAngles;

	// Token: 0x0400011B RID: 283
	[Token(Token = "0x400011B")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 m_CurrentLocalDir;

	// Token: 0x0400011C RID: 284
	[Token(Token = "0x400011C")]
	[FieldOffset(Offset = "0x58")]
	private Matrix4x4 m_ToLocal;
}
