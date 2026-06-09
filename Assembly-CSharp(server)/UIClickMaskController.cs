using System;
using GCommon;
using Il2CppDummyDll;

// Token: 0x02000105 RID: 261
[Token(Token = "0x2000105")]
public class UIClickMaskController : UIPopupWindowController
{
	// Token: 0x060004C2 RID: 1218 RVA: 0x00002D18 File Offset: 0x00000F18
	[Token(Token = "0x60004C2")]
	[Address(RVA = "0x1C9E628", Offset = "0x1C9E628", VA = "0x7BBC49E628")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	// Token: 0x060004C3 RID: 1219 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004C3")]
	[Address(RVA = "0x1C9E678", Offset = "0x1C9E678", VA = "0x7BBC49E678", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	// Token: 0x060004C4 RID: 1220 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004C4")]
	[Address(RVA = "0x1C9E744", Offset = "0x1C9E744", VA = "0x7BBC49E744", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	// Token: 0x060004C5 RID: 1221 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004C5")]
	[Address(RVA = "0x1C9E810", Offset = "0x1C9E810", VA = "0x7BBC49E810")]
	private void OnClickMask(params object[] args)
	{
	}

	// Token: 0x060004C6 RID: 1222 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004C6")]
	[Address(RVA = "0x1C9EBAC", Offset = "0x1C9EBAC", VA = "0x7BBC49EBAC")]
	public void SetGuideWidget(UIWidget widget)
	{
	}

	// Token: 0x060004C7 RID: 1223 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004C7")]
	[Address(RVA = "0x1C9EBB4", Offset = "0x1C9EBB4", VA = "0x7BBC49EBB4")]
	public UIClickMaskController()
	{
	}

	// Token: 0x0400041D RID: 1053
	[Token(Token = "0x400041D")]
	[FieldOffset(Offset = "0x98")]
	private UIWidget m_GuideWidget;
}
