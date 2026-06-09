using System;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001A35 RID: 6709
	[Token(Token = "0x2001A35")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F7BAC", Offset = "0x10F7BAC")]
	public class UIMailItemController : UIEasyListItemController
	{
		// Token: 0x06008CE5 RID: 36069 RVA: 0x00025938 File Offset: 0x00023B38
		[Token(Token = "0x6008CE5")]
		[Address(RVA = "0x1CE4434", Offset = "0x1CE4434", VA = "0x7BBC4E4434")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008CE6 RID: 36070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CE6")]
		[Address(RVA = "0x1CE4484", Offset = "0x1CE4484", VA = "0x7BBC4E4484", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008CE7 RID: 36071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CE7")]
		[Address(RVA = "0x1CE4568", Offset = "0x1CE4568", VA = "0x7BBC4E4568", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x06008CE8 RID: 36072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CE8")]
		[Address(RVA = "0x1CE49F0", Offset = "0x1CE49F0", VA = "0x7BBC4E49F0", Slot = "32")]
		public override void OnItemBtnUnSelect()
		{
		}

		// Token: 0x06008CE9 RID: 36073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CE9")]
		[Address(RVA = "0x1CE4BE8", Offset = "0x1CE4BE8", VA = "0x7BBC4E4BE8", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06008CEA RID: 36074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CEA")]
		[Address(RVA = "0x1CE4850", Offset = "0x1CE4850", VA = "0x7BBC4E4850")]
		private void RefreshMailReadIcon(bool read)
		{
		}

		// Token: 0x06008CEB RID: 36075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008CEB")]
		[Address(RVA = "0x1CE5014", Offset = "0x1CE5014", VA = "0x7BBC4E5014")]
		private string RemainigTime(uint time)
		{
			return null;
		}

		// Token: 0x06008CEC RID: 36076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CEC")]
		[Address(RVA = "0x1CE51DC", Offset = "0x1CE51DC", VA = "0x7BBC4E51DC")]
		public UIMailItemController()
		{
		}

		// Token: 0x04009923 RID: 39203
		[Token(Token = "0x4009923")]
		[FieldOffset(Offset = "0x70")]
		private UIMailItemView m_View;

		// Token: 0x04009924 RID: 39204
		[Token(Token = "0x4009924")]
		[FieldOffset(Offset = "0x78")]
		private MailInfo m_Data;

		// Token: 0x04009925 RID: 39205
		[Token(Token = "0x4009925")]
		[FieldOffset(Offset = "0x80")]
		private int m_Index;

		// Token: 0x04009926 RID: 39206
		[Token(Token = "0x4009926")]
		[FieldOffset(Offset = "0x0")]
		private static Color m_ColorLight;

		// Token: 0x04009927 RID: 39207
		[Token(Token = "0x4009927")]
		[FieldOffset(Offset = "0x10")]
		private static Color m_ColorLightGrey;

		// Token: 0x04009928 RID: 39208
		[Token(Token = "0x4009928")]
		[FieldOffset(Offset = "0x20")]
		private static Color m_ColorDark;

		// Token: 0x04009929 RID: 39209
		[Token(Token = "0x4009929")]
		[FieldOffset(Offset = "0x30")]
		private static Color m_ColorSpriteDark;

		// Token: 0x0400992A RID: 39210
		[Token(Token = "0x400992A")]
		[FieldOffset(Offset = "0x40")]
		private static Color m_ColorSpriteLight;
	}
}
