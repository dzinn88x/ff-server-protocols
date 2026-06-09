using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001898 RID: 6296
	[Token(Token = "0x2001898")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F472C", Offset = "0x10F472C")]
	public class UIHudControlPointPosMarkController : UIHudNameBaseController
	{
		// Token: 0x06007CC9 RID: 31945 RVA: 0x00022428 File Offset: 0x00020628
		[Token(Token = "0x6007CC9")]
		[Address(RVA = "0x1A95890", Offset = "0x1A95890", VA = "0x7BBC295890")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007CCA RID: 31946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CCA")]
		[Address(RVA = "0x1A958E0", Offset = "0x1A958E0", VA = "0x7BBC2958E0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007CCB RID: 31947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CCB")]
		[Address(RVA = "0x1A95D38", Offset = "0x1A95D38", VA = "0x7BBC295D38", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06007CCC RID: 31948 RVA: 0x00022440 File Offset: 0x00020640
		[Token(Token = "0x6007CCC")]
		[Address(RVA = "0x1A95E58", Offset = "0x1A95E58", VA = "0x7BBC295E58", Slot = "28")]
		protected override Vector3 TargetPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06007CCD RID: 31949 RVA: 0x00022458 File Offset: 0x00020658
		[Token(Token = "0x6007CCD")]
		[Address(RVA = "0x1A95F00", Offset = "0x1A95F00", VA = "0x7BBC295F00", Slot = "30")]
		protected override bool NeedKeepInScreen()
		{
			return default(bool);
		}

		// Token: 0x06007CCE RID: 31950 RVA: 0x00022470 File Offset: 0x00020670
		[Token(Token = "0x6007CCE")]
		[Address(RVA = "0x1A95F08", Offset = "0x1A95F08", VA = "0x7BBC295F08", Slot = "37")]
		protected override Vector2 GetWidgetBound()
		{
			return default(Vector2);
		}

		// Token: 0x06007CCF RID: 31951 RVA: 0x00022488 File Offset: 0x00020688
		[Token(Token = "0x6007CCF")]
		[Address(RVA = "0x1A96028", Offset = "0x1A96028", VA = "0x7BBC296028", Slot = "32")]
		protected override bool NeedShowDistance()
		{
			return default(bool);
		}

		// Token: 0x06007CD0 RID: 31952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CD0")]
		[Address(RVA = "0x1A96030", Offset = "0x1A96030", VA = "0x7BBC296030")]
		private void OnOccupateTeamChange(object[] data)
		{
		}

		// Token: 0x06007CD1 RID: 31953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CD1")]
		[Address(RVA = "0x1A96344", Offset = "0x1A96344", VA = "0x7BBC296344")]
		private void Update()
		{
		}

		// Token: 0x06007CD2 RID: 31954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CD2")]
		[Address(RVA = "0x1A96374", Offset = "0x1A96374", VA = "0x7BBC296374")]
		private void OnControlPointChange(object[] data)
		{
		}

		// Token: 0x06007CD3 RID: 31955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CD3")]
		[Address(RVA = "0x1A95B68", Offset = "0x1A95B68", VA = "0x7BBC295B68")]
		private void ClearHudShow()
		{
		}

		// Token: 0x06007CD4 RID: 31956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CD4")]
		[Address(RVA = "0x1A96740", Offset = "0x1A96740", VA = "0x7BBC296740")]
		public UIHudControlPointPosMarkController()
		{
		}

		// Token: 0x04009082 RID: 36994
		[Token(Token = "0x4009082")]
		[FieldOffset(Offset = "0xA8")]
		private UIHudControlPointPosMarkView m_View;

		// Token: 0x04009083 RID: 36995
		[Token(Token = "0x4009083")]
		[FieldOffset(Offset = "0xB0")]
		private Vector3 m_ControlPointPos;

		// Token: 0x04009084 RID: 36996
		[Token(Token = "0x4009084")]
		[FieldOffset(Offset = "0xBC")]
		private uint m_CurrentPointID;

		// Token: 0x04009085 RID: 36997
		[Token(Token = "0x4009085")]
		[FieldOffset(Offset = "0xC0")]
		private UIModelMatch m_ModelMatch;

		// Token: 0x04009086 RID: 36998
		[Token(Token = "0x4009086")]
		private const int NO_OCCUPY_COLOR = 2130706517;

		// Token: 0x04009087 RID: 36999
		[Token(Token = "0x4009087")]
		private const int LOCAL_OCCUPY_COLOR = 2131790519;

		// Token: 0x04009088 RID: 37000
		[Token(Token = "0x4009088")]
		private const int OPP_OCCUPY_COLOR = 2145343516;

		// Token: 0x04009089 RID: 37001
		[Token(Token = "0x4009089")]
		[FieldOffset(Offset = "0xC8")]
		private UITimeLabelHelper m_TimeHelper;
	}
}
