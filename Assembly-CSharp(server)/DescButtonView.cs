using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000126 RID: 294
[Token(Token = "0x2000126")]
public class DescButtonView : MonoBehaviour
{
	// Token: 0x0600057A RID: 1402 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600057A")]
	[Address(RVA = "0x23E57E8", Offset = "0x23E57E8", VA = "0x7BBCBE57E8")]
	public void SetData(string title0, string icon0, Action action, string title1 = "", string icon1 = "", [Optional] Action action1)
	{
	}

	// Token: 0x0600057B RID: 1403 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600057B")]
	[Address(RVA = "0x23E6020", Offset = "0x23E6020", VA = "0x7BBCBE6020")]
	private void OnClickButton()
	{
	}

	// Token: 0x0600057C RID: 1404 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600057C")]
	[Address(RVA = "0x23E6034", Offset = "0x23E6034", VA = "0x7BBCBE6034")]
	private void OnClickButton1()
	{
	}

	// Token: 0x0600057D RID: 1405 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600057D")]
	[Address(RVA = "0x23E6048", Offset = "0x23E6048", VA = "0x7BBCBE6048")]
	public DescButtonView()
	{
	}

	// Token: 0x040004B7 RID: 1207
	[Token(Token = "0x40004B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private UIButton m_Button;

	// Token: 0x040004B8 RID: 1208
	[Token(Token = "0x40004B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private UISprite m_Icon0;

	// Token: 0x040004B9 RID: 1209
	[Token(Token = "0x40004B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private UILabel m_Label0;

	// Token: 0x040004BA RID: 1210
	[Token(Token = "0x40004BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private UISprite m_Icon1;

	// Token: 0x040004BB RID: 1211
	[Token(Token = "0x40004BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private UILabel m_Label1;

	// Token: 0x040004BC RID: 1212
	[Token(Token = "0x40004BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private UIButton m_Button1;

	// Token: 0x040004BD RID: 1213
	[Token(Token = "0x40004BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private UILabel[] m_LabelTitles;

	// Token: 0x040004BE RID: 1214
	[Token(Token = "0x40004BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Action m_Callback;

	// Token: 0x040004BF RID: 1215
	[Token(Token = "0x40004BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Action m_Callback1;

	// Token: 0x040004C0 RID: 1216
	[Token(Token = "0x40004C0")]
	public const string DEFAULT_STRING = "";
}
