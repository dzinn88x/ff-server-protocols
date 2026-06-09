using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000079 RID: 121
[Token(Token = "0x2000079")]
public class VehicleResetPos : MonoBehaviour
{
	// Token: 0x06000176 RID: 374 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000176")]
	[Address(RVA = "0x218BEFC", Offset = "0x218BEFC", VA = "0x7BBC98BEFC")]
	private void OnDrawGizmos()
	{
	}

	// Token: 0x06000177 RID: 375 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000177")]
	[Address(RVA = "0x218C198", Offset = "0x218C198", VA = "0x7BBC98C198")]
	public VehicleResetPos()
	{
	}

	// Token: 0x04000186 RID: 390
	[Token(Token = "0x4000186")]
	[FieldOffset(Offset = "0x18")]
	public Transform m_Transform;

	// Token: 0x04000187 RID: 391
	[Token(Token = "0x4000187")]
	[FieldOffset(Offset = "0x20")]
	public float m_Radius;

	// Token: 0x04000188 RID: 392
	[Token(Token = "0x4000188")]
	[FieldOffset(Offset = "0x24")]
	public int Index;

	// Token: 0x04000189 RID: 393
	[Token(Token = "0x4000189")]
	[FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public float m_Theta;

	// Token: 0x0400018A RID: 394
	[Token(Token = "0x400018A")]
	[FieldOffset(Offset = "0x2C")]
	[HideInInspector]
	public Color m_Color;
}
