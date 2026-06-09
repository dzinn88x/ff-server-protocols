using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02001011 RID: 4113
	[Token(Token = "0x2001011")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EA660", Offset = "0x10EA660")]
	public class UIBaseController : MonoBehaviour, IShare
	{
		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x06003DB1 RID: 15793 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003DB2 RID: 15794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700072A")]
		public UIBaseController ParentController
		{
			[Token(Token = "0x6003DB1")]
			[Address(RVA = "0x2021D1C", Offset = "0x2021D1C", VA = "0x7BBC821D1C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C0A0", Offset = "0x113C0A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003DB2")]
			[Address(RVA = "0x2021D24", Offset = "0x2021D24", VA = "0x7BBC821D24")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C0B0", Offset = "0x113C0B0")]
			private set
			{
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x06003DB3 RID: 15795 RVA: 0x00013470 File Offset: 0x00011670
		// (set) Token: 0x06003DB4 RID: 15796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700072B")]
		public bool IsInit
		{
			[Token(Token = "0x6003DB3")]
			[Address(RVA = "0x2021D2C", Offset = "0x2021D2C", VA = "0x7BBC821D2C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C0C0", Offset = "0x113C0C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003DB4")]
			[Address(RVA = "0x2021D34", Offset = "0x2021D34", VA = "0x7BBC821D34")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C0D0", Offset = "0x113C0D0")]
			internal set
			{
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06003DB5 RID: 15797 RVA: 0x00013488 File Offset: 0x00011688
		// (set) Token: 0x06003DB6 RID: 15798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700072C")]
		public bool IsOpened
		{
			[Token(Token = "0x6003DB5")]
			[Address(RVA = "0x2021D40", Offset = "0x2021D40", VA = "0x7BBC821D40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C0E0", Offset = "0x113C0E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003DB6")]
			[Address(RVA = "0x2021D48", Offset = "0x2021D48", VA = "0x7BBC821D48")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C0F0", Offset = "0x113C0F0")]
			internal set
			{
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06003DB7 RID: 15799 RVA: 0x000134A0 File Offset: 0x000116A0
		// (set) Token: 0x06003DB8 RID: 15800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700072D")]
		public bool IsClosed
		{
			[Token(Token = "0x6003DB7")]
			[Address(RVA = "0x2021D54", Offset = "0x2021D54", VA = "0x7BBC821D54")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C100", Offset = "0x113C100")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003DB8")]
			[Address(RVA = "0x2021D5C", Offset = "0x2021D5C", VA = "0x7BBC821D5C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C110", Offset = "0x113C110")]
			internal set
			{
			}
		}

		// Token: 0x06003DB9 RID: 15801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DB9")]
		[Address(RVA = "0x2021D68", Offset = "0x2021D68", VA = "0x7BBC821D68", Slot = "9")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06003DBA RID: 15802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DBA")]
		[Address(RVA = "0x2021E10", Offset = "0x2021E10", VA = "0x7BBC821E10")]
		public void Close()
		{
		}

		// Token: 0x06003DBB RID: 15803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DBB")]
		[Address(RVA = "0x20222C4", Offset = "0x20222C4", VA = "0x7BBC8222C4")]
		internal void Destroy()
		{
		}

		// Token: 0x06003DBC RID: 15804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DBC")]
		[Address(RVA = "0x2022498", Offset = "0x2022498", VA = "0x7BBC822498")]
		internal void UIOpen()
		{
		}

		// Token: 0x06003DBD RID: 15805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DBD")]
		[Address(RVA = "0x20224B0", Offset = "0x20224B0", VA = "0x7BBC8224B0")]
		internal void UIActiveGroupSwitch(ulong activeGroup)
		{
		}

		// Token: 0x06003DBE RID: 15806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DBE")]
		[Address(RVA = "0x202273C", Offset = "0x202273C", VA = "0x7BBC82273C")]
		public GameObject GetViewRootObject()
		{
			return null;
		}

		// Token: 0x06003DBF RID: 15807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DBF")]
		[Address(RVA = "0x2022744", Offset = "0x2022744", VA = "0x7BBC822744")]
		public Transform GetViewRootTransform()
		{
			return null;
		}

		// Token: 0x06003DC0 RID: 15808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DC0")]
		protected virtual T OpenChildControllerWith3DUI<T>(Transform parent, [Optional] Vector3 localPosition, EUIAnchor anchor = EUIAnchor.None) where T : UIBaseController
		{
			return null;
		}

		// Token: 0x06003DC1 RID: 15809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DC1")]
		protected virtual T OpenChildController<T>(Transform parent, [Optional] Vector3 localPosition, EUIAnchor anchor = EUIAnchor.None, bool noCache = false) where T : UIBaseController
		{
			return null;
		}

		// Token: 0x06003DC2 RID: 15810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DC2")]
		[Address(RVA = "0x2022250", Offset = "0x2022250", VA = "0x7BBC822250")]
		public void RemoveChild(UIBaseController controller)
		{
		}

		// Token: 0x06003DC3 RID: 15811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DC3")]
		[Address(RVA = "0x2022778", Offset = "0x2022778", VA = "0x7BBC822778", Slot = "12")]
		protected virtual void OnChildControllerOpenChildController()
		{
		}

		// Token: 0x06003DC4 RID: 15812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DC4")]
		protected T CreateView<T>() where T : UIBaseView, new()
		{
			return null;
		}

		// Token: 0x06003DC5 RID: 15813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DC5")]
		[Address(RVA = "0x2022818", Offset = "0x2022818", VA = "0x7BBC822818", Slot = "13")]
		protected virtual void OnUIInit()
		{
		}

		// Token: 0x06003DC6 RID: 15814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DC6")]
		[Address(RVA = "0x202281C", Offset = "0x202281C", VA = "0x7BBC82281C", Slot = "14")]
		protected virtual void OnUIOpen()
		{
		}

		// Token: 0x06003DC7 RID: 15815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DC7")]
		[Address(RVA = "0x2022820", Offset = "0x2022820", VA = "0x7BBC822820", Slot = "15")]
		protected virtual void OnUIClose()
		{
		}

		// Token: 0x06003DC8 RID: 15816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DC8")]
		[Address(RVA = "0x2022824", Offset = "0x2022824", VA = "0x7BBC822824", Slot = "16")]
		protected virtual void OnUIDestory()
		{
		}

		// Token: 0x06003DC9 RID: 15817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DC9")]
		[Address(RVA = "0x2022828", Offset = "0x2022828", VA = "0x7BBC822828", Slot = "17")]
		protected virtual void OnUIDestroy()
		{
		}

		// Token: 0x06003DCA RID: 15818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DCA")]
		[Address(RVA = "0x202282C", Offset = "0x202282C", VA = "0x7BBC82282C", Slot = "18")]
		protected virtual void OnUIActiveGroupSwitch(ulong activeGroup)
		{
		}

		// Token: 0x06003DCB RID: 15819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DCB")]
		[Address(RVA = "0x2022830", Offset = "0x2022830", VA = "0x7BBC822830", Slot = "19")]
		protected virtual void OnVisibilityChanged()
		{
		}

		// Token: 0x06003DCC RID: 15820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DCC")]
		[Address(RVA = "0x2022834", Offset = "0x2022834", VA = "0x7BBC822834", Slot = "20")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06003DCD RID: 15821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DCD")]
		[Address(RVA = "0x2022838", Offset = "0x2022838", VA = "0x7BBC822838", Slot = "21")]
		public virtual void Show()
		{
		}

		// Token: 0x06003DCE RID: 15822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DCE")]
		[Address(RVA = "0x2022888", Offset = "0x2022888", VA = "0x7BBC822888", Slot = "22")]
		public virtual void Hide()
		{
		}

		// Token: 0x06003DCF RID: 15823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DCF")]
		[Address(RVA = "0x20228D8", Offset = "0x20228D8", VA = "0x7BBC8228D8")]
		public void SetVisibility(bool v)
		{
		}

		// Token: 0x06003DD0 RID: 15824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DD0")]
		[Address(RVA = "0x202292C", Offset = "0x202292C", VA = "0x7BBC82292C")]
		public void SetNavigationVisibility(bool v)
		{
		}

		// Token: 0x06003DD1 RID: 15825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DD1")]
		[Address(RVA = "0x2022980", Offset = "0x2022980", VA = "0x7BBC822980")]
		public void SetExtraFlagVisibility(bool v)
		{
		}

		// Token: 0x06003DD2 RID: 15826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DD2")]
		[Address(RVA = "0x20229D4", Offset = "0x20229D4", VA = "0x7BBC8229D4")]
		public void SetGamePhaseVisibility(bool v)
		{
		}

		// Token: 0x06003DD3 RID: 15827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DD3")]
		[Address(RVA = "0x2022A28", Offset = "0x2022A28", VA = "0x7BBC822A28")]
		public void SetSettingVisibility(bool v)
		{
		}

		// Token: 0x06003DD4 RID: 15828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DD4")]
		[Address(RVA = "0x2022A7C", Offset = "0x2022A7C", VA = "0x7BBC822A7C")]
		public void SwitchGroup(ulong activeGroup)
		{
		}

		// Token: 0x06003DD5 RID: 15829 RVA: 0x000134B8 File Offset: 0x000116B8
		[Token(Token = "0x6003DD5")]
		[Address(RVA = "0x2022A80", Offset = "0x2022A80", VA = "0x7BBC822A80")]
		public bool IsVisible()
		{
			return default(bool);
		}

		// Token: 0x06003DD6 RID: 15830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DD6")]
		[Address(RVA = "0x2022B9C", Offset = "0x2022B9C", VA = "0x7BBC822B9C")]
		public UIBaseController SetUIGroup(ulong groupFlags)
		{
			return null;
		}

		// Token: 0x06003DD7 RID: 15831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DD7")]
		[Address(RVA = "0x20226A0", Offset = "0x20226A0", VA = "0x7BBC8226A0")]
		private void RefreshVisibility()
		{
		}

		// Token: 0x06003DD8 RID: 15832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DD8")]
		[Address(RVA = "0x2022BE8", Offset = "0x2022BE8", VA = "0x7BBC822BE8")]
		public static void SetGameObjectActive(GameObject go, bool flag, [Optional] Action<bool> changed)
		{
		}

		// Token: 0x06003DD9 RID: 15833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DD9")]
		[Address(RVA = "0x2022CD4", Offset = "0x2022CD4", VA = "0x7BBC822CD4", Slot = "23")]
		public virtual void BeforeScreenshot()
		{
		}

		// Token: 0x06003DDA RID: 15834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DDA")]
		[Address(RVA = "0x2022CD8", Offset = "0x2022CD8", VA = "0x7BBC822CD8", Slot = "24")]
		public virtual void AfterScreenshot()
		{
		}

		// Token: 0x06003DDB RID: 15835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DDB")]
		[Address(RVA = "0x2022CDC", Offset = "0x2022CDC", VA = "0x7BBC822CDC", Slot = "25")]
		public virtual void BeforeSharePreview()
		{
		}

		// Token: 0x06003DDC RID: 15836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DDC")]
		[Address(RVA = "0x2022CE0", Offset = "0x2022CE0", VA = "0x7BBC822CE0", Slot = "26")]
		public virtual void AfterSharePreview()
		{
		}

		// Token: 0x06003DDD RID: 15837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DDD")]
		[Address(RVA = "0x2022CE4", Offset = "0x2022CE4", VA = "0x7BBC822CE4", Slot = "27")]
		public virtual void OnShare(bool success, int platform)
		{
		}

		// Token: 0x06003DDE RID: 15838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DDE")]
		[Address(RVA = "0x2022CE8", Offset = "0x2022CE8", VA = "0x7BBC822CE8")]
		public UIBaseController()
		{
		}

		// Token: 0x04004E74 RID: 20084
		[Token(Token = "0x4004E74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112EA64", Offset = "0x112EA64")]
		private UIBaseController <ParentController>k__BackingField;

		// Token: 0x04004E75 RID: 20085
		[Token(Token = "0x4004E75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112EA74", Offset = "0x112EA74")]
		private bool <IsInit>k__BackingField;

		// Token: 0x04004E76 RID: 20086
		[Token(Token = "0x4004E76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112EA84", Offset = "0x112EA84")]
		private bool <IsOpened>k__BackingField;

		// Token: 0x04004E77 RID: 20087
		[Token(Token = "0x4004E77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112EA94", Offset = "0x112EA94")]
		private bool <IsClosed>k__BackingField;

		// Token: 0x04004E78 RID: 20088
		[Token(Token = "0x4004E78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		public bool IsRootController;

		// Token: 0x04004E79 RID: 20089
		[Token(Token = "0x4004E79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected List<UIBaseController> m_ChildControllers;

		// Token: 0x04004E7A RID: 20090
		[Token(Token = "0x4004E7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected BitArray64 m_UIGroup;

		// Token: 0x04004E7B RID: 20091
		[Token(Token = "0x4004E7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private uint VISIBILITY_STATE_GROUP;

		// Token: 0x04004E7C RID: 20092
		[Token(Token = "0x4004E7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private uint VISIBILITY_STATE_SHOWHIDE;

		// Token: 0x04004E7D RID: 20093
		[Token(Token = "0x4004E7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private uint VISIBILITY_STATE_NAVIGATION;

		// Token: 0x04004E7E RID: 20094
		[Token(Token = "0x4004E7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private uint VISIBILITY_STATE_EXTRAFLAG;

		// Token: 0x04004E7F RID: 20095
		[Token(Token = "0x4004E7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private uint VISIBILITY_STATE_GAMEPHASE;

		// Token: 0x04004E80 RID: 20096
		[Token(Token = "0x4004E80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private uint VISIBILITY_STATE_SETTING;

		// Token: 0x04004E81 RID: 20097
		[Token(Token = "0x4004E81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BitArrayBoolean m_StoredActiveState;
	}
}
