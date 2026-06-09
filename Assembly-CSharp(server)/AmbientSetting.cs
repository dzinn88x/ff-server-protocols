using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001EA RID: 490
[Token(Token = "0x20001EA")]
public class AmbientSetting : MonoBehaviour
{
	// Token: 0x060009F3 RID: 2547 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009F3")]
	[Address(RVA = "0x1F83718", Offset = "0x1F83718", VA = "0x7BBC783718")]
	private void OnEnable()
	{
	}

	// Token: 0x060009F4 RID: 2548 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009F4")]
	[Address(RVA = "0x1F83760", Offset = "0x1F83760", VA = "0x7BBC783760")]
	private void OnDisable()
	{
	}

	// Token: 0x060009F5 RID: 2549 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009F5")]
	[Address(RVA = "0x1F83770", Offset = "0x1F83770", VA = "0x7BBC783770")]
	public AmbientSetting()
	{
	}

	// Token: 0x04000964 RID: 2404
	[Token(Token = "0x4000964")]
	[FieldOffset(Offset = "0x18")]
	public Color ambientColor;

	// Token: 0x04000965 RID: 2405
	[Token(Token = "0x4000965")]
	[FieldOffset(Offset = "0x28")]
	private Color _orginalColor;
}
