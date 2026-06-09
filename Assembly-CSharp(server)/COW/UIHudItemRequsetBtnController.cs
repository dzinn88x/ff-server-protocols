using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020018F5 RID: 6389
	[Token(Token = "0x20018F5")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F5484", Offset = "0x10F5484")]
	internal class UIHudItemRequsetBtnController : UIBaseController
	{
		// Token: 0x0600802D RID: 32813 RVA: 0x00022F80 File Offset: 0x00021180
		[Token(Token = "0x600802D")]
		[Address(RVA = "0x1C4AD7C", Offset = "0x1C4AD7C", VA = "0x7BBC44AD7C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600802E RID: 32814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600802E")]
		[Address(RVA = "0x1C4ADCC", Offset = "0x1C4ADCC", VA = "0x7BBC44ADCC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600802F RID: 32815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600802F")]
		[Address(RVA = "0x1C4B06C", Offset = "0x1C4B06C", VA = "0x7BBC44B06C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008030 RID: 32816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008030")]
		[Address(RVA = "0x1C4B204", Offset = "0x1C4B204", VA = "0x7BBC44B204")]
		private void OnEnterMarkItemCDTime(params object[] param)
		{
		}

		// Token: 0x06008031 RID: 32817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008031")]
		[Address(RVA = "0x1C4B20C", Offset = "0x1C4B20C", VA = "0x7BBC44B20C")]
		private void Update()
		{
		}

		// Token: 0x06008032 RID: 32818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008032")]
		[Address(RVA = "0x1C4B3E8", Offset = "0x1C4B3E8", VA = "0x7BBC44B3E8")]
		private void OnPressHud(GameObject go, bool state)
		{
		}

		// Token: 0x06008033 RID: 32819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008033")]
		[Address(RVA = "0x1C4B518", Offset = "0x1C4B518", VA = "0x7BBC44B518")]
		private void OnDragOutHud(GameObject go)
		{
		}

		// Token: 0x06008034 RID: 32820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008034")]
		[Address(RVA = "0x1C4B5F8", Offset = "0x1C4B5F8", VA = "0x7BBC44B5F8")]
		private void OnClickHud(GameObject go)
		{
		}

		// Token: 0x06008035 RID: 32821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008035")]
		[Address(RVA = "0x1C4B6D0", Offset = "0x1C4B6D0", VA = "0x7BBC44B6D0")]
		private void CheckForGuideClick()
		{
		}

		// Token: 0x06008036 RID: 32822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008036")]
		[Address(RVA = "0x1C4B8FC", Offset = "0x1C4B8FC", VA = "0x7BBC44B8FC")]
		private void CheckForGuidePress()
		{
		}

		// Token: 0x06008037 RID: 32823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008037")]
		[Address(RVA = "0x1C4B7FC", Offset = "0x1C4B7FC", VA = "0x7BBC44B7FC")]
		private void TryGetHintItemInScene()
		{
		}

		// Token: 0x06008038 RID: 32824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008038")]
		[Address(RVA = "0x1C4B4B8", Offset = "0x1C4B4B8", VA = "0x7BBC44B4B8")]
		private void ChangePressState(bool state)
		{
		}

		// Token: 0x06008039 RID: 32825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008039")]
		[Address(RVA = "0x1C4C158", Offset = "0x1C4C158", VA = "0x7BBC44C158")]
		private void OnFinishPressed()
		{
		}

		// Token: 0x0600803A RID: 32826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600803A")]
		[Address(RVA = "0x1C4B9AC", Offset = "0x1C4B9AC", VA = "0x7BBC44B9AC")]
		private void TryShowItemGridWindow(LevelContainerBase container, bool isTriggerOpen)
		{
		}

		// Token: 0x0600803B RID: 32827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600803B")]
		[Address(RVA = "0x1C4C1FC", Offset = "0x1C4C1FC", VA = "0x7BBC44C1FC")]
		private void RequestMarkItem(uint itemID, uint containerID, Vector3 position, bool isTriggerOpen)
		{
		}

		// Token: 0x0600803C RID: 32828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600803C")]
		[Address(RVA = "0x1C4C33C", Offset = "0x1C4C33C", VA = "0x7BBC44C33C")]
		private void OnEnterPickupArea(params object[] param)
		{
		}

		// Token: 0x0600803D RID: 32829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600803D")]
		[Address(RVA = "0x1C4C498", Offset = "0x1C4C498", VA = "0x7BBC44C498")]
		private void OnExitPickupArea(params object[] param)
		{
		}

		// Token: 0x0600803E RID: 32830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600803E")]
		[Address(RVA = "0x1C4C188", Offset = "0x1C4C188", VA = "0x7BBC44C188")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1142EEC", Offset = "0x1142EEC")]
		private IEnumerator StartDelayCallWnd()
		{
			return null;
		}

		// Token: 0x0600803F RID: 32831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600803F")]
		[Address(RVA = "0x1C4C4CC", Offset = "0x1C4C4CC", VA = "0x7BBC44C4CC")]
		public UIHudItemRequsetBtnController()
		{
		}

		// Token: 0x04009288 RID: 37512
		[Token(Token = "0x4009288")]
		private const float UI_PRESSTIME_TRIGGERTIME = 1.5f;

		// Token: 0x04009289 RID: 37513
		[Token(Token = "0x4009289")]
		[FieldOffset(Offset = "0x58")]
		private UIHudItemMarkBtnView m_View;

		// Token: 0x0400928A RID: 37514
		[Token(Token = "0x400928A")]
		[FieldOffset(Offset = "0x60")]
		private LevelContainerBase m_CurrentTriggerContainer;

		// Token: 0x0400928B RID: 37515
		[Token(Token = "0x400928B")]
		[FieldOffset(Offset = "0x68")]
		private bool m_pressState;

		// Token: 0x0400928C RID: 37516
		[Token(Token = "0x400928C")]
		[FieldOffset(Offset = "0x6C")]
		private float m_pressTime;

		// Token: 0x0400928D RID: 37517
		[Token(Token = "0x400928D")]
		[FieldOffset(Offset = "0x70")]
		private bool m_BtnClickCanUse;

		// Token: 0x0400928E RID: 37518
		[Token(Token = "0x400928E")]
		[FieldOffset(Offset = "0x74")]
		private float m_currentCD;

		// Token: 0x0400928F RID: 37519
		[Token(Token = "0x400928F")]
		[FieldOffset(Offset = "0x78")]
		private uint m_DelayCall;

		// Token: 0x020018F6 RID: 6390
		[Token(Token = "0x20018F6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F54BC", Offset = "0x10F54BC")]
		private sealed class <StartDelayCallWnd>d__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06008040 RID: 32832 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008040")]
			[Address(RVA = "0x1C4C4A0", Offset = "0x1C4C4A0", VA = "0x7BBC44C4A0")]
			[DebuggerHidden]
			public <StartDelayCallWnd>d__25(int <>1__state)
			{
			}

			// Token: 0x06008041 RID: 32833 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008041")]
			[Address(RVA = "0x1C4C4DC", Offset = "0x1C4C4DC", VA = "0x7BBC44C4DC", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06008042 RID: 32834 RVA: 0x00022F98 File Offset: 0x00021198
			[Token(Token = "0x6008042")]
			[Address(RVA = "0x1C4C4E0", Offset = "0x1C4C4E0", VA = "0x7BBC44C4E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700099E RID: 2462
			// (get) Token: 0x06008043 RID: 32835 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700099E")]
			private object Current
			{
				[Token(Token = "0x6008043")]
				[Address(RVA = "0x1C4C5B4", Offset = "0x1C4C5B4", VA = "0x7BBC44C5B4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06008044 RID: 32836 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008044")]
			[Address(RVA = "0x1C4C5BC", Offset = "0x1C4C5BC", VA = "0x7BBC44C5BC", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700099F RID: 2463
			// (get) Token: 0x06008045 RID: 32837 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700099F")]
			private object Current
			{
				[Token(Token = "0x6008045")]
				[Address(RVA = "0x1C4C624", Offset = "0x1C4C624", VA = "0x7BBC44C624", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04009290 RID: 37520
			[Token(Token = "0x4009290")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04009291 RID: 37521
			[Token(Token = "0x4009291")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04009292 RID: 37522
			[Token(Token = "0x4009292")]
			[FieldOffset(Offset = "0x20")]
			public UIHudItemRequsetBtnController <>4__this;
		}
	}
}
