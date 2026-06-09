using System;
using Il2CppDummyDll;

// Token: 0x020000D0 RID: 208
[Token(Token = "0x20000D0")]
[Attribute(Name = "AddComponentMenu", RVA = "0x10E1D40", Offset = "0x10E1D40")]
[Attribute(Name = "RequireComponent", RVA = "0x10E1D40", Offset = "0x10E1D40")]
public class TweenProgressBar : UITweener
{
	// Token: 0x17000041 RID: 65
	// (get) Token: 0x0600037E RID: 894 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000041")]
	public UIProgressBar cachedProgress
	{
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x1C97020", Offset = "0x1C97020", VA = "0x7BBC497020")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000042 RID: 66
	// (get) Token: 0x0600037F RID: 895 RVA: 0x000029A0 File Offset: 0x00000BA0
	// (set) Token: 0x06000380 RID: 896 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000042")]
	public float value
	{
		[Token(Token = "0x600037F")]
		[Address(RVA = "0x1C970B8", Offset = "0x1C970B8", VA = "0x7BBC4970B8")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000380")]
		[Address(RVA = "0x1C970E8", Offset = "0x1C970E8", VA = "0x7BBC4970E8")]
		set
		{
		}
	}

	// Token: 0x06000381 RID: 897 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000381")]
	[Address(RVA = "0x1C97128", Offset = "0x1C97128", VA = "0x7BBC497128", Slot = "5")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	// Token: 0x06000382 RID: 898 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000382")]
	[Address(RVA = "0x1C971B8", Offset = "0x1C971B8", VA = "0x7BBC4971B8")]
	public static TweenProgressBar Play(UIProgressBar processBar, float duration, float from, float to)
	{
		return null;
	}

	// Token: 0x06000383 RID: 899 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000383")]
	[Address(RVA = "0x1C972A4", Offset = "0x1C972A4", VA = "0x7BBC4972A4", Slot = "6")]
	[Attribute(Name = "ContextMenu", RVA = "0x1132AD8", Offset = "0x1132AD8")]
	public override void SetStartToCurrentValue()
	{
	}

	// Token: 0x06000384 RID: 900 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000384")]
	[Address(RVA = "0x1C972C8", Offset = "0x1C972C8", VA = "0x7BBC4972C8", Slot = "7")]
	[Attribute(Name = "ContextMenu", RVA = "0x1132B10", Offset = "0x1132B10")]
	public override void SetEndToCurrentValue()
	{
	}

	// Token: 0x06000385 RID: 901 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000385")]
	[Address(RVA = "0x1C972EC", Offset = "0x1C972EC", VA = "0x7BBC4972EC")]
	[Attribute(Name = "ContextMenu", RVA = "0x1132B48", Offset = "0x1132B48")]
	private void SetCurrentValueToStart()
	{
	}

	// Token: 0x06000386 RID: 902 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000386")]
	[Address(RVA = "0x1C972F4", Offset = "0x1C972F4", VA = "0x7BBC4972F4")]
	[Attribute(Name = "ContextMenu", RVA = "0x1132B80", Offset = "0x1132B80")]
	private void SetCurrentValueToEnd()
	{
	}

	// Token: 0x06000387 RID: 903 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000387")]
	[Address(RVA = "0x1C972FC", Offset = "0x1C972FC", VA = "0x7BBC4972FC")]
	public TweenProgressBar()
	{
	}

	// Token: 0x0400034C RID: 844
	[Token(Token = "0x400034C")]
	[FieldOffset(Offset = "0x78")]
	public float from;

	// Token: 0x0400034D RID: 845
	[Token(Token = "0x400034D")]
	[FieldOffset(Offset = "0x7C")]
	public float to;

	// Token: 0x0400034E RID: 846
	[Token(Token = "0x400034E")]
	[FieldOffset(Offset = "0x80")]
	private UIProgressBar m_ProgressBar;
}
