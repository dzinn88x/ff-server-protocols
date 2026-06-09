using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020018B4 RID: 6324
	[Token(Token = "0x20018B4")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F4A2C", Offset = "0x10F4A2C")]
	internal class UIHudEscortBossNameController : UIBaseController
	{
		// Token: 0x06007DBC RID: 32188 RVA: 0x00022758 File Offset: 0x00020958
		[Token(Token = "0x6007DBC")]
		[Address(RVA = "0x1C0402C", Offset = "0x1C0402C", VA = "0x7BBC40402C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007DBD RID: 32189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DBD")]
		[Address(RVA = "0x1C0407C", Offset = "0x1C0407C", VA = "0x7BBC40407C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007DBE RID: 32190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DBE")]
		[Address(RVA = "0x1C046B0", Offset = "0x1C046B0", VA = "0x7BBC4046B0", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06007DBF RID: 32191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DBF")]
		[Address(RVA = "0x1C0486C", Offset = "0x1C0486C", VA = "0x7BBC40486C")]
		private void InitCamera()
		{
		}

		// Token: 0x06007DC0 RID: 32192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DC0")]
		[Address(RVA = "0x1C049EC", Offset = "0x1C049EC", VA = "0x7BBC4049EC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007DC1 RID: 32193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DC1")]
		[Address(RVA = "0x1C04BB0", Offset = "0x1C04BB0", VA = "0x7BBC404BB0", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06007DC2 RID: 32194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DC2")]
		[Address(RVA = "0x1C04BB8", Offset = "0x1C04BB8", VA = "0x7BBC404BB8")]
		private void OnWheelHPChanged(params object[] data)
		{
		}

		// Token: 0x06007DC3 RID: 32195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DC3")]
		[Address(RVA = "0x1C04CEC", Offset = "0x1C04CEC", VA = "0x7BBC404CEC")]
		private void OnBodyHPChanged(params object[] data)
		{
		}

		// Token: 0x06007DC4 RID: 32196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DC4")]
		[Address(RVA = "0x1C04E20", Offset = "0x1C04E20", VA = "0x7BBC404E20")]
		private void OnVehicleStateChanged(params object[] data)
		{
		}

		// Token: 0x06007DC5 RID: 32197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DC5")]
		[Address(RVA = "0x1C045C4", Offset = "0x1C045C4", VA = "0x7BBC4045C4")]
		private void UpdateRepairStatus()
		{
		}

		// Token: 0x06007DC6 RID: 32198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DC6")]
		[Address(RVA = "0x1C04BBC", Offset = "0x1C04BBC", VA = "0x7BBC404BBC")]
		private void UpdateWheelHPUI()
		{
		}

		// Token: 0x06007DC7 RID: 32199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DC7")]
		[Address(RVA = "0x1C04CF0", Offset = "0x1C04CF0", VA = "0x7BBC404CF0")]
		private void UpdateBodyHPUI()
		{
		}

		// Token: 0x06007DC8 RID: 32200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DC8")]
		[Address(RVA = "0x1C04E24", Offset = "0x1C04E24", VA = "0x7BBC404E24")]
		private void SetContainerActive(bool active)
		{
		}

		// Token: 0x06007DC9 RID: 32201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DC9")]
		[Address(RVA = "0x1C04E6C", Offset = "0x1C04E6C", VA = "0x7BBC404E6C")]
		public void BindTarget(LevelEscortMatchBoss boss)
		{
		}

		// Token: 0x06007DCA RID: 32202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DCA")]
		[Address(RVA = "0x1C04E94", Offset = "0x1C04E94", VA = "0x7BBC404E94")]
		private void LateUpdate()
		{
		}

		// Token: 0x06007DCB RID: 32203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DCB")]
		[Address(RVA = "0x1C04F1C", Offset = "0x1C04F1C", VA = "0x7BBC404F1C")]
		private void UpdateNamePosition()
		{
		}

		// Token: 0x06007DCC RID: 32204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DCC")]
		[Address(RVA = "0x1C056E4", Offset = "0x1C056E4", VA = "0x7BBC4056E4")]
		private void SetDistance(int distance)
		{
		}

		// Token: 0x06007DCD RID: 32205 RVA: 0x00022770 File Offset: 0x00020970
		[Token(Token = "0x6007DCD")]
		[Address(RVA = "0x1C056B4", Offset = "0x1C056B4", VA = "0x7BBC4056B4")]
		private Vector3 GetRefPos()
		{
			return default(Vector3);
		}

		// Token: 0x06007DCE RID: 32206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DCE")]
		[Address(RVA = "0x1C05834", Offset = "0x1C05834", VA = "0x7BBC405834")]
		private void SetViewActive(GameObject obj, bool active)
		{
		}

		// Token: 0x06007DCF RID: 32207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DCF")]
		[Address(RVA = "0x1C04244", Offset = "0x1C04244", VA = "0x7BBC404244")]
		private void ShowArrow(UIHudEscortBossNameController.EArrowDirection direction)
		{
		}

		// Token: 0x06007DD0 RID: 32208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007DD0")]
		[Address(RVA = "0x1C05928", Offset = "0x1C05928", VA = "0x7BBC405928")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1142B64", Offset = "0x1142B64")]
		private IEnumerator RemoveNameInfo(float delayTime)
		{
			return null;
		}

		// Token: 0x06007DD1 RID: 32209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DD1")]
		[Address(RVA = "0x1C059EC", Offset = "0x1C059EC", VA = "0x7BBC4059EC")]
		public UIHudEscortBossNameController()
		{
		}

		// Token: 0x04009133 RID: 37171
		[Token(Token = "0x4009133")]
		[FieldOffset(Offset = "0x58")]
		private UIHudEscortBossNameView m_View;

		// Token: 0x04009134 RID: 37172
		[Token(Token = "0x4009134")]
		[FieldOffset(Offset = "0x60")]
		private Camera m_FollowCamera;

		// Token: 0x04009135 RID: 37173
		[Token(Token = "0x4009135")]
		[FieldOffset(Offset = "0x68")]
		private Camera m_UICamera;

		// Token: 0x04009136 RID: 37174
		[Token(Token = "0x4009136")]
		[FieldOffset(Offset = "0x70")]
		private StringBuilder m_Distance;

		// Token: 0x04009137 RID: 37175
		[Token(Token = "0x4009137")]
		[FieldOffset(Offset = "0x78")]
		private int m_PrevDistance;

		// Token: 0x04009138 RID: 37176
		[Token(Token = "0x4009138")]
		[FieldOffset(Offset = "0x7C")]
		private float viewPortBoundary;

		// Token: 0x04009139 RID: 37177
		[Token(Token = "0x4009139")]
		[FieldOffset(Offset = "0x80")]
		private LevelEscortMatchBoss m_Boss;

		// Token: 0x0400913A RID: 37178
		[Token(Token = "0x400913A")]
		private const float ARROW_ICON_HALF_SIZE = 21f;

		// Token: 0x020018B5 RID: 6325
		[Token(Token = "0x20018B5")]
		private enum EArrowDirection
		{
			// Token: 0x0400913C RID: 37180
			[Token(Token = "0x400913C")]
			NONE,
			// Token: 0x0400913D RID: 37181
			[Token(Token = "0x400913D")]
			UP,
			// Token: 0x0400913E RID: 37182
			[Token(Token = "0x400913E")]
			DOWN,
			// Token: 0x0400913F RID: 37183
			[Token(Token = "0x400913F")]
			LEFT,
			// Token: 0x04009140 RID: 37184
			[Token(Token = "0x4009140")]
			RIGHT
		}

		// Token: 0x020018B6 RID: 6326
		[Token(Token = "0x20018B6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F4A64", Offset = "0x10F4A64")]
		private sealed class <RemoveNameInfo>d__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06007DD2 RID: 32210 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DD2")]
			[Address(RVA = "0x1C059C0", Offset = "0x1C059C0", VA = "0x7BBC4059C0")]
			[DebuggerHidden]
			public <RemoveNameInfo>d__29(int <>1__state)
			{
			}

			// Token: 0x06007DD3 RID: 32211 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DD3")]
			[Address(RVA = "0x1C059FC", Offset = "0x1C059FC", VA = "0x7BBC4059FC", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06007DD4 RID: 32212 RVA: 0x00022788 File Offset: 0x00020988
			[Token(Token = "0x6007DD4")]
			[Address(RVA = "0x1C05A00", Offset = "0x1C05A00", VA = "0x7BBC405A00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000994 RID: 2452
			// (get) Token: 0x06007DD5 RID: 32213 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000994")]
			private object Current
			{
				[Token(Token = "0x6007DD5")]
				[Address(RVA = "0x1C05ABC", Offset = "0x1C05ABC", VA = "0x7BBC405ABC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06007DD6 RID: 32214 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DD6")]
			[Address(RVA = "0x1C05AC4", Offset = "0x1C05AC4", VA = "0x7BBC405AC4", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000995 RID: 2453
			// (get) Token: 0x06007DD7 RID: 32215 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000995")]
			private object Current
			{
				[Token(Token = "0x6007DD7")]
				[Address(RVA = "0x1C05B2C", Offset = "0x1C05B2C", VA = "0x7BBC405B2C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04009141 RID: 37185
			[Token(Token = "0x4009141")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04009142 RID: 37186
			[Token(Token = "0x4009142")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04009143 RID: 37187
			[Token(Token = "0x4009143")]
			[FieldOffset(Offset = "0x20")]
			public float delayTime;

			// Token: 0x04009144 RID: 37188
			[Token(Token = "0x4009144")]
			[FieldOffset(Offset = "0x28")]
			public UIHudEscortBossNameController <>4__this;
		}
	}
}
