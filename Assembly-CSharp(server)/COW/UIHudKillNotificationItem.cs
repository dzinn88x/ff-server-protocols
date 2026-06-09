using System;
using System.Text;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C50 RID: 7248
	[Token(Token = "0x2001C50")]
	internal class UIHudKillNotificationItem : MonoBehaviour
	{
		// Token: 0x17000A66 RID: 2662
		// (set) Token: 0x06009DA8 RID: 40360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A66")]
		public bool PlainVerbColor
		{
			[Token(Token = "0x6009DA8")]
			[Address(RVA = "0x1C4FB34", Offset = "0x1C4FB34", VA = "0x7BBC44FB34")]
			set
			{
			}
		}

		// Token: 0x06009DA9 RID: 40361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DA9")]
		[Address(RVA = "0x1C4FBAC", Offset = "0x1C4FBAC", VA = "0x7BBC44FBAC")]
		public void SetActive(bool v)
		{
		}

		// Token: 0x06009DAA RID: 40362 RVA: 0x00029418 File Offset: 0x00027618
		[Token(Token = "0x6009DAA")]
		[Address(RVA = "0x1C50264", Offset = "0x1C50264", VA = "0x7BBC450264")]
		public bool IsActive(float gameTime)
		{
			return default(bool);
		}

		// Token: 0x06009DAB RID: 40363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DAB")]
		[Address(RVA = "0x1C502E0", Offset = "0x1C502E0", VA = "0x7BBC4502E0")]
		public void MoveTo(UIHudKillNotificationItem item)
		{
		}

		// Token: 0x06009DAC RID: 40364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DAC")]
		[Address(RVA = "0x1C51BA8", Offset = "0x1C51BA8", VA = "0x7BBC451BA8", Slot = "4")]
		public virtual void SetKillInfo(float gameTime, PendingNotification notification)
		{
		}

		// Token: 0x06009DAD RID: 40365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DAD")]
		[Address(RVA = "0x1C52D54", Offset = "0x1C52D54", VA = "0x7BBC452D54")]
		public UIHudKillNotificationItem()
		{
		}

		// Token: 0x0400A3E5 RID: 41957
		[Token(Token = "0x400A3E5")]
		[FieldOffset(Offset = "0x18")]
		public GameObject InfoContainer;

		// Token: 0x0400A3E6 RID: 41958
		[Token(Token = "0x400A3E6")]
		[FieldOffset(Offset = "0x20")]
		public UILabel text;

		// Token: 0x0400A3E7 RID: 41959
		[Token(Token = "0x400A3E7")]
		[FieldOffset(Offset = "0x28")]
		public GameObject m_RedEnvelopeGo;

		// Token: 0x0400A3E8 RID: 41960
		[Token(Token = "0x400A3E8")]
		[FieldOffset(Offset = "0x30")]
		public UISprite m_NotifyIcon;

		// Token: 0x0400A3E9 RID: 41961
		[Token(Token = "0x400A3E9")]
		[FieldOffset(Offset = "0x38")]
		public UILabel m_RedEnvelopeLabel;

		// Token: 0x0400A3EA RID: 41962
		[Token(Token = "0x400A3EA")]
		[FieldOffset(Offset = "0x40")]
		public UISprite m_BonusIcon;

		// Token: 0x0400A3EB RID: 41963
		[Token(Token = "0x400A3EB")]
		[FieldOffset(Offset = "0x48")]
		private Timer m_ShowupTimer;

		// Token: 0x0400A3EC RID: 41964
		[Token(Token = "0x400A3EC")]
		[FieldOffset(Offset = "0x50")]
		private string m_KillVerbColor;

		// Token: 0x0400A3ED RID: 41965
		[Token(Token = "0x400A3ED")]
		[FieldOffset(Offset = "0x58")]
		private StringBuilder m_TextBuilder;
	}
}
