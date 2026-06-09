using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000E8 RID: 232
[Token(Token = "0x20000E8")]
public class UIPopWindowFrameStyle : MonoBehaviour
{
	// Token: 0x06000404 RID: 1028 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000404")]
	[Address(RVA = "0x1FCA808", Offset = "0x1FCA808", VA = "0x7BBC7CA808")]
	public void InitStyle(GameObject framePrefab, UIBaseController parentController)
	{
	}

	// Token: 0x06000405 RID: 1029 RVA: 0x00002B20 File Offset: 0x00000D20
	[Token(Token = "0x6000405")]
	[Address(RVA = "0x1FCA928", Offset = "0x1FCA928", VA = "0x7BBC7CA928")]
	public static ResourceID GetFrameResourceId(UIFrameSize size)
	{
		return default(ResourceID);
	}

	// Token: 0x06000406 RID: 1030 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000406")]
	[Address(RVA = "0x1FCAA10", Offset = "0x1FCAA10", VA = "0x7BBC7CAA10")]
	public void UpdateFrameTitleKey(string newKey)
	{
	}

	// Token: 0x06000407 RID: 1031 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000407")]
	[Address(RVA = "0x1FCAAFC", Offset = "0x1FCAAFC", VA = "0x7BBC7CAAFC")]
	public UIPopWindowFrameStyle()
	{
	}

	// Token: 0x040003B1 RID: 945
	[Token(Token = "0x40003B1")]
	[FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public UIPopupWindowController parentPopupWindow;

	// Token: 0x040003B2 RID: 946
	[Token(Token = "0x40003B2")]
	[FieldOffset(Offset = "0x20")]
	public UIFrameSize frameSize;

	// Token: 0x040003B3 RID: 947
	[Token(Token = "0x40003B3")]
	[FieldOffset(Offset = "0x28")]
	public string titleKey;

	// Token: 0x040003B4 RID: 948
	[Token(Token = "0x40003B4")]
	[FieldOffset(Offset = "0x30")]
	public bool unuseCloseBtn;

	// Token: 0x040003B5 RID: 949
	[Token(Token = "0x40003B5")]
	[FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public UIPopWindowFrameController frameController;
}
