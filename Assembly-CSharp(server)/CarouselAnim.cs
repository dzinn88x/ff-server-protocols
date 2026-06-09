using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000D9 RID: 217
[Token(Token = "0x20000D9")]
public class CarouselAnim : MonoBehaviour
{
	// Token: 0x060003B6 RID: 950 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B6")]
	[Address(RVA = "0x23DFF3C", Offset = "0x23DFF3C", VA = "0x7BBCBDFF3C")]
	private void Start()
	{
	}

	// Token: 0x060003B7 RID: 951 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x23E01A4", Offset = "0x23E01A4", VA = "0x7BBCBE01A4")]
	private void Update()
	{
	}

	// Token: 0x060003B8 RID: 952 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003B8")]
	[Address(RVA = "0x23DFFF0", Offset = "0x23DFFF0", VA = "0x7BBCBDFFF0")]
	private TweenAlpha InitTween(UIWidget widget, bool front)
	{
		return null;
	}

	// Token: 0x060003B9 RID: 953 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B9")]
	[Address(RVA = "0x23E032C", Offset = "0x23E032C", VA = "0x7BBCBE032C")]
	private void OnDisable()
	{
	}

	// Token: 0x060003BA RID: 954 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x23E0330", Offset = "0x23E0330", VA = "0x7BBCBE0330")]
	private void Reset()
	{
	}

	// Token: 0x060003BB RID: 955 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x23E0368", Offset = "0x23E0368", VA = "0x7BBCBE0368")]
	public CarouselAnim()
	{
	}

	// Token: 0x0400037C RID: 892
	[Token(Token = "0x400037C")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget front;

	// Token: 0x0400037D RID: 893
	[Token(Token = "0x400037D")]
	[FieldOffset(Offset = "0x20")]
	public UIWidget back;

	// Token: 0x0400037E RID: 894
	[Token(Token = "0x400037E")]
	[FieldOffset(Offset = "0x28")]
	public float animDuration;

	// Token: 0x0400037F RID: 895
	[Token(Token = "0x400037F")]
	[FieldOffset(Offset = "0x2C")]
	public float waitTime;

	// Token: 0x04000380 RID: 896
	[Token(Token = "0x4000380")]
	[FieldOffset(Offset = "0x30")]
	private float deltaTime;

	// Token: 0x04000381 RID: 897
	[Token(Token = "0x4000381")]
	[FieldOffset(Offset = "0x34")]
	private int index;

	// Token: 0x04000382 RID: 898
	[Token(Token = "0x4000382")]
	[FieldOffset(Offset = "0x38")]
	private TweenAlpha frontAnim;

	// Token: 0x04000383 RID: 899
	[Token(Token = "0x4000383")]
	[FieldOffset(Offset = "0x40")]
	private TweenAlpha backAnim;
}
