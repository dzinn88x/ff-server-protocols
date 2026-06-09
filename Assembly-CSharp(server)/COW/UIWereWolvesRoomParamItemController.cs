using System;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x02001C0D RID: 7181
	[Token(Token = "0x2001C0D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FB654", Offset = "0x10FB654")]
	internal class UIWereWolvesRoomParamItemController : UIBaseController
	{
		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06009C5F RID: 40031 RVA: 0x00029070 File Offset: 0x00027270
		// (set) Token: 0x06009C60 RID: 40032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A5E")]
		private uint CurParamValue
		{
			[Token(Token = "0x6009C5F")]
			[Address(RVA = "0x1791740", Offset = "0x1791740", VA = "0x7BBBF91740")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6009C60")]
			[Address(RVA = "0x1791748", Offset = "0x1791748", VA = "0x7BBBF91748")]
			set
			{
			}
		}

		// Token: 0x06009C61 RID: 40033 RVA: 0x00029088 File Offset: 0x00027288
		[Token(Token = "0x6009C61")]
		[Address(RVA = "0x1791874", Offset = "0x1791874", VA = "0x7BBBF91874")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009C62 RID: 40034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C62")]
		[Address(RVA = "0x17918C4", Offset = "0x17918C4", VA = "0x7BBBF918C4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009C63 RID: 40035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C63")]
		[Address(RVA = "0x1791AB0", Offset = "0x1791AB0", VA = "0x7BBBF91AB0")]
		public void InitSettingData(INp{ZCe paramType, WereWolvesRoomSettingData settingData, Action<INp{ZCe, uint> callBack)
		{
		}

		// Token: 0x06009C64 RID: 40036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C64")]
		[Address(RVA = "0x1791CAC", Offset = "0x1791CAC", VA = "0x7BBBF91CAC")]
		public void UpdateCurParam(uint param)
		{
		}

		// Token: 0x06009C65 RID: 40037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C65")]
		[Address(RVA = "0x1791CB0", Offset = "0x1791CB0", VA = "0x7BBBF91CB0")]
		private void OnClickMin()
		{
		}

		// Token: 0x06009C66 RID: 40038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C66")]
		[Address(RVA = "0x1791CE4", Offset = "0x1791CE4", VA = "0x7BBBF91CE4")]
		private void OnClickMax()
		{
		}

		// Token: 0x06009C67 RID: 40039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C67")]
		[Address(RVA = "0x1791D18", Offset = "0x1791D18", VA = "0x7BBBF91D18")]
		private void OnClickPlus()
		{
		}

		// Token: 0x06009C68 RID: 40040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C68")]
		[Address(RVA = "0x1791D5C", Offset = "0x1791D5C", VA = "0x7BBBF91D5C")]
		private void OnClickSub()
		{
		}

		// Token: 0x06009C69 RID: 40041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C69")]
		[Address(RVA = "0x1791DA0", Offset = "0x1791DA0", VA = "0x7BBBF91DA0")]
		public UIWereWolvesRoomParamItemController()
		{
		}

		// Token: 0x0400A233 RID: 41523
		[Token(Token = "0x400A233")]
		[FieldOffset(Offset = "0x58")]
		private UIWereWolvesRoomParamItemView m_View;

		// Token: 0x0400A234 RID: 41524
		[Token(Token = "0x400A234")]
		[FieldOffset(Offset = "0x60")]
		private uint m_CurParamValue;

		// Token: 0x0400A235 RID: 41525
		[Token(Token = "0x400A235")]
		[FieldOffset(Offset = "0x64")]
		private INp{ZCe m_ParamType;

		// Token: 0x0400A236 RID: 41526
		[Token(Token = "0x400A236")]
		[FieldOffset(Offset = "0x68")]
		private Action<INp{ZCe, uint> m_ParamChangeCallBack;

		// Token: 0x0400A237 RID: 41527
		[Token(Token = "0x400A237")]
		[FieldOffset(Offset = "0x70")]
		private WereWolvesRoomSettingData m_SettingData;
	}
}
