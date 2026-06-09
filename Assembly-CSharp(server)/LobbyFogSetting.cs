using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001F6 RID: 502
[Token(Token = "0x20001F6")]
public class LobbyFogSetting : MonoBehaviour
{
	// Token: 0x06000A0E RID: 2574 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A0E")]
	[Address(RVA = "0x2539080", Offset = "0x2539080", VA = "0x7BBCD39080")]
	private void OnEnable()
	{
	}

	// Token: 0x06000A0F RID: 2575 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A0F")]
	[Address(RVA = "0x2539104", Offset = "0x2539104", VA = "0x7BBCD39104")]
	private void Update()
	{
	}

	// Token: 0x06000A10 RID: 2576 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A10")]
	[Address(RVA = "0x253914C", Offset = "0x253914C", VA = "0x7BBCD3914C")]
	private void OnDisable()
	{
	}

	// Token: 0x06000A11 RID: 2577 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A11")]
	[Address(RVA = "0x2539198", Offset = "0x2539198", VA = "0x7BBCD39198")]
	public LobbyFogSetting()
	{
	}

	// Token: 0x0400097A RID: 2426
	[Token(Token = "0x400097A")]
	[FieldOffset(Offset = "0x18")]
	public bool updateEveryFrame;

	// Token: 0x0400097B RID: 2427
	[Token(Token = "0x400097B")]
	[FieldOffset(Offset = "0x1C")]
	public Color fogColor;

	// Token: 0x0400097C RID: 2428
	[Token(Token = "0x400097C")]
	[FieldOffset(Offset = "0x2C")]
	public float fogEndDistance;

	// Token: 0x0400097D RID: 2429
	[Token(Token = "0x400097D")]
	[FieldOffset(Offset = "0x30")]
	private bool _fogEnabled;

	// Token: 0x0400097E RID: 2430
	[Token(Token = "0x400097E")]
	[FieldOffset(Offset = "0x34")]
	private FogMode _fogMode;

	// Token: 0x0400097F RID: 2431
	[Token(Token = "0x400097F")]
	[FieldOffset(Offset = "0x38")]
	private float _originalEndDistance;

	// Token: 0x04000980 RID: 2432
	[Token(Token = "0x4000980")]
	[FieldOffset(Offset = "0x3C")]
	private Color _orginalColor;
}
