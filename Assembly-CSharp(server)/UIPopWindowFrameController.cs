using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000E6 RID: 230
[Token(Token = "0x20000E6")]
public class UIPopWindowFrameController : MonoBehaviour
{
	// Token: 0x060003FF RID: 1023 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003FF")]
	[Address(RVA = "0x1FCA240", Offset = "0x1FCA240", VA = "0x7BBC7CA240")]
	public void InitFrame(UIBaseController parentController, UIPopWindowFrameStyle frameStyle)
	{
	}

	// Token: 0x06000400 RID: 1024 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000400")]
	[Address(RVA = "0x1FCA58C", Offset = "0x1FCA58C", VA = "0x7BBC7CA58C")]
	public void SetFrameDepth(int newDepth)
	{
	}

	// Token: 0x06000401 RID: 1025 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000401")]
	[Address(RVA = "0x1FCA5C4", Offset = "0x1FCA5C4", VA = "0x7BBC7CA5C4")]
	public void OnBtnRuleClick()
	{
	}

	// Token: 0x06000402 RID: 1026 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000402")]
	[Address(RVA = "0x1FCA738", Offset = "0x1FCA738", VA = "0x7BBC7CA738")]
	public void SetCloseBtnVisble(bool flag)
	{
	}

	// Token: 0x06000403 RID: 1027 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000403")]
	[Address(RVA = "0x1FCA800", Offset = "0x1FCA800", VA = "0x7BBC7CA800")]
	public UIPopWindowFrameController()
	{
	}

	// Token: 0x040003A5 RID: 933
	[Token(Token = "0x40003A5")]
	[FieldOffset(Offset = "0x18")]
	public UIPanel m_MainPanel;

	// Token: 0x040003A6 RID: 934
	[Token(Token = "0x40003A6")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnClose;

	// Token: 0x040003A7 RID: 935
	[Token(Token = "0x40003A7")]
	[FieldOffset(Offset = "0x28")]
	public UILabel LabelTitle;

	// Token: 0x040003A8 RID: 936
	[Token(Token = "0x40003A8")]
	[FieldOffset(Offset = "0x30")]
	public UIButton BtnRule;

	// Token: 0x040003A9 RID: 937
	[Token(Token = "0x40003A9")]
	[FieldOffset(Offset = "0x38")]
	private string m_RuleKey;
}
