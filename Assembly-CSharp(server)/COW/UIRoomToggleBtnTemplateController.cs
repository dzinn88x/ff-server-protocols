using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001B75 RID: 7029
	[Token(Token = "0x2001B75")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA1AC", Offset = "0x10FA1AC")]
	public class UIRoomToggleBtnTemplateController : UIBaseController
	{
		// Token: 0x0600975A RID: 38746 RVA: 0x00027F00 File Offset: 0x00026100
		[Token(Token = "0x600975A")]
		[Address(RVA = "0x1A23F14", Offset = "0x1A23F14", VA = "0x7BBC223F14")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600975B RID: 38747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600975B")]
		[Address(RVA = "0x1A23F64", Offset = "0x1A23F64", VA = "0x7BBC223F64", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600975C RID: 38748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600975C")]
		[Address(RVA = "0x1A240A0", Offset = "0x1A240A0", VA = "0x7BBC2240A0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600975D RID: 38749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600975D")]
		[Address(RVA = "0x1A240C8", Offset = "0x1A240C8", VA = "0x7BBC2240C8")]
		public void SetToggleBtnInfo(bool initEnabled, string labelTxt, string enabledTxt = "TXT_OB9_ZJS_ROOM_WATCH_SWITCH_YES", string disabledTxt = "TXT_OB9_ZJS_ROOM_WATCH_SWITCH_NO")
		{
		}

		// Token: 0x0600975E RID: 38750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600975E")]
		[Address(RVA = "0x1A242F8", Offset = "0x1A242F8", VA = "0x7BBC2242F8")]
		public void RegisterCallBack(Action enableCB, Action disableCB)
		{
		}

		// Token: 0x0600975F RID: 38751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600975F")]
		[Address(RVA = "0x1A24300", Offset = "0x1A24300", VA = "0x7BBC224300")]
		private void OnEnabledClick()
		{
		}

		// Token: 0x06009760 RID: 38752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009760")]
		[Address(RVA = "0x1A24314", Offset = "0x1A24314", VA = "0x7BBC224314")]
		private void OnDisabledClick()
		{
		}

		// Token: 0x06009761 RID: 38753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009761")]
		[Address(RVA = "0x1A24328", Offset = "0x1A24328", VA = "0x7BBC224328")]
		public void ChooseFirst(bool first)
		{
		}

		// Token: 0x06009762 RID: 38754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009762")]
		[Address(RVA = "0x1A243E4", Offset = "0x1A243E4", VA = "0x7BBC2243E4")]
		public void SetEnabled(bool enabled)
		{
		}

		// Token: 0x06009763 RID: 38755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009763")]
		[Address(RVA = "0x1A24540", Offset = "0x1A24540", VA = "0x7BBC224540")]
		public void SetStates(ERoom.DropPresetState state)
		{
		}

		// Token: 0x06009764 RID: 38756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009764")]
		[Address(RVA = "0x1A245CC", Offset = "0x1A245CC", VA = "0x7BBC2245CC")]
		public UIRoomToggleBtnTemplateController()
		{
		}

		// Token: 0x04009F91 RID: 40849
		[Token(Token = "0x4009F91")]
		[FieldOffset(Offset = "0x58")]
		private UIRoomToggleBtnTemplateView m_View;

		// Token: 0x04009F92 RID: 40850
		[Token(Token = "0x4009F92")]
		[FieldOffset(Offset = "0x60")]
		private Action m_EnableClickCallback;

		// Token: 0x04009F93 RID: 40851
		[Token(Token = "0x4009F93")]
		[FieldOffset(Offset = "0x68")]
		private Action m_DisableClickCallback;
	}
}
