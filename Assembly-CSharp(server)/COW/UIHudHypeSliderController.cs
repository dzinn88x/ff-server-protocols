using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020018DF RID: 6367
	[Token(Token = "0x20018DF")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F50D4", Offset = "0x10F50D4")]
	public class UIHudHypeSliderController : UIBaseController
	{
		// Token: 0x06007F0F RID: 32527 RVA: 0x00022B60 File Offset: 0x00020D60
		[Token(Token = "0x6007F0F")]
		[Address(RVA = "0x1984B20", Offset = "0x1984B20", VA = "0x7BBC184B20")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06007F10 RID: 32528 RVA: 0x00022B78 File Offset: 0x00020D78
		// (set) Token: 0x06007F11 RID: 32529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700099A")]
		public bool HadHypeValueChanged
		{
			[Token(Token = "0x6007F10")]
			[Address(RVA = "0x1984B70", Offset = "0x1984B70", VA = "0x7BBC184B70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007F11")]
			[Address(RVA = "0x1984B78", Offset = "0x1984B78", VA = "0x7BBC184B78")]
			set
			{
			}
		}

		// Token: 0x06007F12 RID: 32530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F12")]
		[Address(RVA = "0x1984C38", Offset = "0x1984C38", VA = "0x7BBC184C38", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007F13 RID: 32531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F13")]
		[Address(RVA = "0x19853D0", Offset = "0x19853D0", VA = "0x7BBC1853D0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007F14 RID: 32532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F14")]
		[Address(RVA = "0x198564C", Offset = "0x198564C", VA = "0x7BBC18564C")]
		private void Update()
		{
		}

		// Token: 0x06007F15 RID: 32533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F15")]
		[Address(RVA = "0x1985A88", Offset = "0x1985A88", VA = "0x7BBC185A88")]
		private void ShowNumJump(float progress)
		{
		}

		// Token: 0x06007F16 RID: 32534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F16")]
		[Address(RVA = "0x19857CC", Offset = "0x19857CC", VA = "0x7BBC1857CC")]
		private void ShowSliderValueChange(float progress)
		{
		}

		// Token: 0x06007F17 RID: 32535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F17")]
		[Address(RVA = "0x19858B8", Offset = "0x19858B8", VA = "0x7BBC1858B8")]
		private void OnFootBallRadiusChange(float radius)
		{
		}

		// Token: 0x06007F18 RID: 32536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F18")]
		[Address(RVA = "0x1985B6C", Offset = "0x1985B6C", VA = "0x7BBC185B6C")]
		private void OnFootBallStatusChange(object[] data)
		{
		}

		// Token: 0x06007F19 RID: 32537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F19")]
		[Address(RVA = "0x1985C88", Offset = "0x1985C88", VA = "0x7BBC185C88")]
		private void OnHypeValueChange(object[] data)
		{
		}

		// Token: 0x06007F1A RID: 32538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F1A")]
		[Address(RVA = "0x1985E8C", Offset = "0x1985E8C", VA = "0x7BBC185E8C", Slot = "28")]
		protected virtual void OnHypeLevelChange(object[] data)
		{
		}

		// Token: 0x06007F1B RID: 32539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F1B")]
		[Address(RVA = "0x1986318", Offset = "0x1986318", VA = "0x7BBC186318")]
		private void OnMaxHypeValueChange(object[] data)
		{
		}

		// Token: 0x06007F1C RID: 32540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F1C")]
		[Address(RVA = "0x1986390", Offset = "0x1986390", VA = "0x7BBC186390")]
		private void OnMaxHypeLevelChange(object[] data)
		{
		}

		// Token: 0x06007F1D RID: 32541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F1D")]
		[Address(RVA = "0x198641C", Offset = "0x198641C", VA = "0x7BBC18641C")]
		private void UpdateBarItem()
		{
		}

		// Token: 0x06007F1E RID: 32542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F1E")]
		[Address(RVA = "0x1985D60", Offset = "0x1985D60", VA = "0x7BBC185D60")]
		private void RefreshHypeValueState()
		{
		}

		// Token: 0x06007F1F RID: 32543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F1F")]
		[Address(RVA = "0x19860B4", Offset = "0x19860B4", VA = "0x7BBC1860B4")]
		private void ResetLevelBlockStateAndSliderBgPos(ushort newLevel)
		{
		}

		// Token: 0x06007F20 RID: 32544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F20")]
		[Address(RVA = "0x198691C", Offset = "0x198691C", VA = "0x7BBC18691C", Slot = "29")]
		protected virtual void ShowMaxHypeLevelEffect(bool _needshow)
		{
		}

		// Token: 0x06007F21 RID: 32545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F21")]
		[Address(RVA = "0x1985F44", Offset = "0x1985F44", VA = "0x7BBC185F44")]
		private void ShowHypeLevelUpAnim()
		{
		}

		// Token: 0x06007F22 RID: 32546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F22")]
		[Address(RVA = "0x1985D74", Offset = "0x1985D74", VA = "0x7BBC185D74")]
		private void ShowHypeChangeEffect(bool isIncreasing)
		{
		}

		// Token: 0x06007F23 RID: 32547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F23")]
		[Address(RVA = "0x19869F4", Offset = "0x19869F4", VA = "0x7BBC1869F4")]
		private void OnSwitchObserver(params object[] data)
		{
		}

		// Token: 0x06007F24 RID: 32548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F24")]
		[Address(RVA = "0x1986A04", Offset = "0x1986A04", VA = "0x7BBC186A04")]
		public UIHudHypeSliderController()
		{
		}

		// Token: 0x0400921F RID: 37407
		[Token(Token = "0x400921F")]
		[FieldOffset(Offset = "0x58")]
		private UIHudHypeProcessBarView m_View;

		// Token: 0x04009220 RID: 37408
		[Token(Token = "0x4009220")]
		private const float m_HypeResetValue = 0f;

		// Token: 0x04009221 RID: 37409
		[Token(Token = "0x4009221")]
		[FieldOffset(Offset = "0x60")]
		private ushort m_CurrentHypeValue;

		// Token: 0x04009222 RID: 37410
		[Token(Token = "0x4009222")]
		[FieldOffset(Offset = "0x62")]
		private ushort m_LastHypeValue;

		// Token: 0x04009223 RID: 37411
		[Token(Token = "0x4009223")]
		[FieldOffset(Offset = "0x64")]
		private ushort m_MaxHypeValue;

		// Token: 0x04009224 RID: 37412
		[Token(Token = "0x4009224")]
		[FieldOffset(Offset = "0x66")]
		protected ushort m_CurrentHypeLevel;

		// Token: 0x04009225 RID: 37413
		[Token(Token = "0x4009225")]
		[FieldOffset(Offset = "0x68")]
		private ushort m_MaxHypeLevel;

		// Token: 0x04009226 RID: 37414
		[Token(Token = "0x4009226")]
		[FieldOffset(Offset = "0x6C")]
		private float m_HypeChangeProcess;

		// Token: 0x04009227 RID: 37415
		[Token(Token = "0x4009227")]
		private const int m_SliderChangeSpeed = 3;

		// Token: 0x04009228 RID: 37416
		[Token(Token = "0x4009228")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<ushort, Transform> m_LevelUpBlockDic;

		// Token: 0x04009229 RID: 37417
		[Token(Token = "0x4009229")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<ushort, Transform> m_LevelBgDic;

		// Token: 0x0400922A RID: 37418
		[Token(Token = "0x400922A")]
		private const int TOTAL_BAR_WIDTH = 190;

		// Token: 0x0400922B RID: 37419
		[Token(Token = "0x400922B")]
		private const float m_HypeValueChangedPassedTime = 2f;

		// Token: 0x0400922C RID: 37420
		[Token(Token = "0x400922C")]
		[FieldOffset(Offset = "0x80")]
		private bool m_HypeValueHadChanged;

		// Token: 0x0400922D RID: 37421
		[Token(Token = "0x400922D")]
		[FieldOffset(Offset = "0x84")]
		private float m_Timer;

		// Token: 0x0400922E RID: 37422
		[Token(Token = "0x400922E")]
		[FieldOffset(Offset = "0x88")]
		private bool m_IsFootball;
	}
}
